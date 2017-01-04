using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm core helpers.</summary>
    public static class GithubfarmCore
    {
        /// <summary>Check whether a entry size is a power of two.</summary>
        public static bool IsEntryPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Express a report entry count as a percentage.</summary>
        public static double ReportEntryPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Express a batches queue count as a percentage.</summary>
        public static double BatchesQueuePercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Find the peak order sample.</summary>
        public static double OrderPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }

        /// <summary>Compute the greatest common divisor of two context sizes.</summary>
        public static long ContextGcd(long a, long b)
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

        /// <summary>Convert a profile temperature from celsius to fahrenheit.</summary>
        public static double ProfileCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
