// Program 1 : Develop a console application to display sum of digits.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_1
{
     public class Program
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            String line = Console.ReadLine();
            int number = 0;
            bool result = Int32.TryParse(line, out number);

            if (result)
            {
                Console.WriteLine("Input Number = " + number);
                int sum = 0;
                while(number > 0)
                {
                    int r = number % 10;
                    sum  += r;
                    number /= 10;

                }
                Console.WriteLine("Sum of Digits : " + sum);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.Read();
        }
    }
}
