using System;

namespace additional_methods_practice
{
    class Program
    {
        
        public static string NewMethod(string p)
        {
           return p.ToLower();   

        }

        static void Main(string[] args)
        {
            Console.WriteLine($"This method returns any string to all lower case characters..." +
                $"Please type in a string and see the results...thanks");
            string input;
            input = Console.ReadLine();
            Console.WriteLine(NewMethod(input));

            Console.ReadKey();


        }
    }
}
