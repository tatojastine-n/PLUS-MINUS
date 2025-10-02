using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int positive = 0;
        int negative = 0;
        int zero = 0;
        
        foreach (int num in arr)
        {
            if (num > 0)
            {
                positive++;
            }
            else if (num < 0)
            {
                negative++;
            }
            else
            {
                zero++;
            }
        }
        
        double ratioPositive = (double)positive / arr.Count;
        double ratioNegative = (double)negative / arr.Count;
        double ratioZero = (double)zero / arr.Count;
        
        Console.WriteLine("{0:F6}", ratioPositive);
        Console.WriteLine("{0:F6}", ratioNegative);
        Console.WriteLine("{0:F6}", ratioZero);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
