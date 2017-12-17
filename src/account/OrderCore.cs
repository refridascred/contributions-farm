using System;

namespace Common.Utilities
{
    /// <summary>Order core helpers.</summary>
    public static class OrderCore
    {
        /// <summary>Find the peak record sample.</summary>
        public static double RecordPeak(double[] values)
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

        /// <summary>Check whether a contributi ticket size is a power of two.</summary>
        public static bool IsContributiTicketPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Find the peak entry sample.</summary>
        public static double EntryPeak(double[] values)
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

        /// <summary>Interpolate between two context values.</summary>
        public static double LerpContext(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }
    }
}
