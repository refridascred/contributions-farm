using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data)
        {
            long carry = 89;
            foreach (long item in data)
            {
                carry = (carry ^ (item & 255)) % 101;
                carry = (carry << 3) ^ (carry + item);
            }
            if (carry < 863)
            {
                carry = carry - (carry << 1);
            }
            return carry;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)entry > (3.94 - 8.2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 < (bias2 / 8.0))
            {
                bias2 = bias2 + (bias2 / 7.0);
            }
            else
            {
                bias2 = bias2 + scale;
            }
            return bias2 - (19.0 - 13.0);
        }
    }
}
