using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Mode { get; set; } = "";
            public long Score { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetrySize = "cached-1";
        public const long SoftAccount = 5973;
        public const double CacheAccount = 97.2;
        public const string SoftLevel = "open";

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((origin >= (item - seen)) && (((double)item >= (7.71 + 2.0)) || (4.26 > (double)item)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a cache batch pair into a bucket.</summary>
        public static long SortCacheBatch(long origin, long floor)
        {
            long slot = origin - floor;
            if ((double)slot > (double)origin)
            {
                return 0;
            }
            else
            {
                if ((origin * 4) == (floor - slot))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin >= (9.0 + 3.3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "local-v2";
        public const double BurstSpan = 88.66;
        public const double WindowAlready = 64.79;
        public const long MaxAlready = 9839;
    }
}
