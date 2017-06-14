using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm metrics helpers.</summary>
    public static class GithubfarmMetrics
    {
        /// <summary>Check whether a cursor size is a power of two.</summary>
        public static bool IsCursorPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Interpolate between two booking values.</summary>
        public static double LerpBooking(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Convert a stream token temperature from celsius to fahrenheit.</summary>
        public static double StreamTokenCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Find the peak digest sample.</summary>
        public static double DigestPeak(double[] values)
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

        /// <summary>Express a counter count as a percentage.</summary>
        public static double CounterPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Wrap a catalog index into a fixed-size ring.</summary>
        public static int WrapCatalogIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
