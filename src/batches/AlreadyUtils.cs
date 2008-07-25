using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstLevel = 1237;
        public const double BaseDepth = 39.2;
        public const string IdleSize = "staging-edge";
        public const long HardBudget = 3770;
        public const long MinMetrics = 8120;

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double bias, double bias2)
        {
            double gain = bias;
            if (gain >= bias)
            {
                gain = (gain + 3.0) + bias2;
            }
            return gain + 8.3;
        }

        /// <summary>Check that every session format entry stays within the limit.</summary>
        public static bool VerifySessionFormatRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((seed < (item % 2)) || ((item ^ 8) <= tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] readings)
        {
            long total = -27;
            foreach (long value in readings)
            {
                total = (total - total) + value;
            }
            return total % 4096;
        }
    }
}
