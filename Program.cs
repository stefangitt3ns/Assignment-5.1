using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 121;
            char lastCharacter = '0'; 
             
            if (x < 1)
            {
                Console.WriteLine("This number is not palandromic");
                return;
            }
            else if (x > 1)
            {
                string integerString = x.ToString(); 
                if (integerString[integerString.Length - 1] == lastCharacter)
                {
                    Console.WriteLine("This number is not palindromic");
                    return;
                }
            }
            else
            {
                int num = x, rev, sum = 0, 
                temp = x;

                while (num > 0)
                {
                    rev = num % 10;           // Get the last digit
                    sum = (sum * 10) + rev;  // Build the reversed number
                    num = num / 10;          // Remove the last digit
                }

                // Check if the reversed number matches the original
                if (temp == sum)
                    Console.WriteLine("Yay! The given number is a Palindrome.");
                else
                    Console.WriteLine("Oops! The given number is not a Palindrome.");

            }

            Console.ReadKey();


        }
    }
}
