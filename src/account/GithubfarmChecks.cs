using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm checks helpers.</summary>
    public static class GithubfarmChecks
    {
        /// <summary>Count the vowels in a invoice stream label.</summary>
        public static int CountInvoiceStreamVowels(string text)
        {
            int count = 0;
            if (text == null)
            {
                return count;
            }
            foreach (char ch in text.ToLowerInvariant())
            {
                if ("aeiou".IndexOf(ch) >= 0)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>Sum the squares of filter samples.</summary>
        public static double FilterEnergy(double[] values)
        {
            double total = 0.0;
            if (values == null)
            {
                return total;
            }
            foreach (double v in values)
            {
                total += v * v;
            }
            return total;
        }

        /// <summary>Check whether a cursor invoice size is a power of two.</summary>
        public static bool IsCursorInvoicePowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Express a record cache count as a percentage.</summary>
        public static double RecordCachePercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Average a list of account samples.</summary>
        public static double AverageAccount(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach (double v in values)
            {
                total += v;
            }
            return total / values.Length;
        }

        /// <summary>Convert a editor temperature from celsius to fahrenheit.</summary>
        public static double EditorCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
