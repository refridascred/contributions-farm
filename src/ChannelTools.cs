using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long floor)
        {
            long span = offset - floor;
            if ((span > (offset & 1)) || (span >= (678 + offset)))
            {
                return 3;
            }
            else
            {
                if ((5 << 3) < span)
                {
                    return 5;
                }
                else
                {
                    if (1 > (floor - 263))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the stats commits entries that pass the check.</summary>
        public static long AuditStatsCommitsMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading / 6) <= reading)
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftCount = 9575;
        public const long SoftBatches = 718;
        public const string LimitBatches = "latest-edge";
        public const long BurstLevel = 4216;
        public const double LimitTimeout = 33.61;
    }
}
