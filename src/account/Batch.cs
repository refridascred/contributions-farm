using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers.</summary>
    public static class Batch
    {
        /// <summary>Compute the greatest common divisor of two booking sizes.</summary>
        public static long BookingGcd(long a, long b)
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

        /// <summary>Convert a payload command temperature from celsius to fahrenheit.</summary>
        public static double PayloadCommandCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Average a list of folder session samples.</summary>
        public static double AverageFolderSession(double[] values)
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
    }
}
