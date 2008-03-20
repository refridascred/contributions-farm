using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 9181;
        public const string HardSize = "latest-1";
        public const long IdleFilter = 8568;
        public const string HardLevel = "fallback-v2";
        public const string CacheSpan = "local-1";

        /// <summary>Count the commits stats entries that pass the check.</summary>
        public static long AuditCommitsStatsGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((827 % 60) >= (item - item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Size { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a order contributi value against two limits.</summary>
        public static long BucketOrderContributi(long origin, long bound)
        {
            long cur = origin ^ bound;
            if (((cur % 16) == (bound - cur)) || ((origin >> 4) == (bound ^ cur)))
            {
                return 0;
            }
            else
            {
                if ((cur - bound) <= (origin * 5))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin == (3.3 - 6.7))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((cur + cur) >= (origin * 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
