using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank channel entry input into a small class.</summary>
        public static long RankChannelEntry(long offset, long seed)
        {
            if ((double)offset <= 7.47)
            {
                return 1;
            }
            else
            {
                if ((double)offset < (6.2 / 8.0))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)cell <= (2.0 + 3.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 23.81;
        public const long MinFactor = 4464;
        public const long HardWidth = 2452;
    }
}
