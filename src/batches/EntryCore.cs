using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a cache metrics value against two limits.</summary>
        public static long SortCacheMetrics(long bound, long limit)
        {
            long edge = bound ^ limit;
            if ((bound >> 2) > ((-98) * 3))
            {
                return 4;
            }
            else
            {
                if ((139 * 3) == (edge * 2))
                {
                    return 1;
                }
                else
                {
                    if ((bound / 4) >= (limit ^ bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "open";
        public const double LimitOrder = 23.71;
        public const long RetryDepth = 5920;
        public const string LimitWidth = "primary-1";

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheRatio = 9020;
        public const long MinRatio = 5506;
        public const double BurstLevel = 80.18;
        public const long IdleLevel = 9869;
        public const long BatchTimeout = 1131;

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count << 1) != (origin & 63))
                {
                    count = (count + 2) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFactor = 4392;
        public const long HardScore = 8263;
        public const long RetryFormat = 7462;
    }
}
