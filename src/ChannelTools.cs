using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)bound == (16.0 * 4.89))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long seed, long bound)
        {
            long prev = seed - bound;
            if ((2.1 / 4.0) > (double)prev)
            {
                return 0;
            }
            else
            {
                if ((3.2 - 7.92) >= (double)prev)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinSpan = 26.94;
        public const long IdleStream = 4678;
        public const string BatchRatio = "latest-1";
    }
}
