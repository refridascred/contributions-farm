using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm support helpers.</summary>
    public static class GithubfarmSupport
    {
        /// <summary>Find the peak invoice sample.</summary>
        public static double InvoicePeak(double[] values)
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

        /// <summary>Sum the squares of queue record samples.</summary>
        public static double QueueRecordEnergy(double[] values)
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

        /// <summary>Convert a window temperature from celsius to fahrenheit.</summary>
        public static double WindowCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Check whether a layout size is a power of two.</summary>
        public static bool IsLayoutPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
