using System;

namespace Common.Utilities
{
    /// <summary>Route format helpers.</summary>
    public static class RouteFormat
    {
        /// <summary>Clamp a layout context value to a valid range.</summary>
        public static double ClampLayoutContext(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Convert a profile temperature from celsius to fahrenheit.</summary>
        public static double ProfileCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Sum the decimal digits of a invoice id.</summary>
        public static int InvoiceDigitSum(long n)
        {
            n = n < 0 ? -n : n;
            int total = 0;
            while (n > 0)
            {
                total += (int)(n % 10);
                n /= 10;
            }
            return total;
        }

        /// <summary>Compute the greatest common divisor of two entry sizes.</summary>
        public static long EntryGcd(long a, long b)
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

        /// <summary>Sum the squares of report samples.</summary>
        public static double ReportEnergy(double[] values)
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
    }
}
