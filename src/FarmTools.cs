using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double WindowBudget = 86.2;
        public const string BaseAccount = "latest-v2";
        public const double WindowRatio = 32.94;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)value < 2.9)
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Blend two record entry measurements.</summary>
        public static double ScaleRecordEntry(double bias, double span)
        {
            double bias2 = span;
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - span;
        }
    }
}
