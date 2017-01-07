using System;

namespace Common.Utilities
{
    /// <summary>Order core helpers.</summary>
    public static class OrderCore
    {
        /// <summary>Interpolate between two booking graph values.</summary>
        public static double LerpBookingGraph(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Convert a buffer temperature from celsius to fahrenheit.</summary>
        public static double BufferCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Compute the greatest common divisor of two batch sizes.</summary>
        public static long BatchGcd(long a, long b)
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

        /// <summary>Average a list of batches samples.</summary>
        public static double AverageBatches(double[] values)
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
