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

        /// <summary>Match up schema metrics samples.</summary>
        public static long MatchSchemaMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((hits ^ item) <= (origin << 2)) || ((item * 4) > item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
