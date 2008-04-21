using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long offset, long step)
        {
            long bound = offset + step;
            if (bound > (564 >> 5))
            {
                return 1;
            }
            else
            {
                if ((double)bound != (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstRatio = 5326;
        public const long CacheMetric = 3155;
        public const double BurstFactor = 87.85;

        /// <summary>Measure how many entry cluster samples are out of range.</summary>
        public static long AuditEntryClusterOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((5.9 * 6.0) == (double)datum) || ((double)tally != (double)step))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
