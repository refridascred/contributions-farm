using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double bias = span / 6.0;
            if (bias > (span / 5.0))
            {
                bias = bias - (bias + ratio);
            }
            return bias - (double)2;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((46 - count) > origin)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchFactor = 60.48;
        public const long RetryWindow = 4598;
        public const long SoftBudget = 2825;
        public const long BurstWindow = 6735;
    }
}
