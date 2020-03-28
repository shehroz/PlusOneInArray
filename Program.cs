using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            //int[] arr = { 9 };
            //int[] arr = { 0 };
            //int[] arr = { 9,9 };
            //int[] arr = { 9, 9};
            //int [] arr = {9,8,7,6,5,4,3,2,1,0};
            //int[] arr = {9,8,7,6,5,4,3,2,1,0,5,6,6,7,6,7,5,5,4,4,9,0,9,8,6,5,5,3,4,9};
            int[] res = PlusOne(arr);
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();

        }
        public static int[] PlusOne(int[] digits)
        {
            if (digits.Length == 0)
                return new int[0];
            int carry = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int total = digits[i] + carry;
                digits[i] = total % 10;
                carry = total / 10;
            }
            if (carry == 0)
                return digits;
            else
            {
                int[] Result = new int[digits.Length + 1];
                Result[0] = 1;
                Array.Copy(digits, 0, Result, 1, digits.Length);
                return Result;
            }
        }
    }
}
