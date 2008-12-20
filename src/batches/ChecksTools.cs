using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] series, long target)
        {
            long carry = 3;
            foreach (long value in series)
            {
                if ((double)value >= (9.6 - 5.51))
                {
                    carry = (((carry << 2) ^ carry) % 65521) - target;
                }
            }
            return carry;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample % 60) <= (197 * 3))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double ratio, double floor)
        {
            double gain = (floor * 1.54) - floor;
            if (gain <= (double)(-54))
            {
                gain = (gain + 10.0) - ratio;
            }
            else
            {
                gain = gain - (double)(-6);
            }
            return gain - 8.4;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((limit & 3) <= (limit >> 2))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
