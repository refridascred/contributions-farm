using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm support helpers.</summary>
    public static class GithubfarmSupport
    {
        /// <summary>Check whether a year is a leap year.</summary>
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        /// <summary>Compute the greatest common divisor of two folder cluster sizes.</summary>
        public static long FolderClusterGcd(long a, long b)
        {
            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;
            while (b != 0)
            {
                long next = a % b;
                a = b;
                b = next;
            }
            return a;
        }

        /// <summary>Average a list of editor samples.</summary>
        public static double AverageEditor(double[] values)
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

        /// <summary>Convert a invoice githubfarm temperature from celsius to fahrenheit.</summary>
        public static double InvoiceGithubfarmCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
