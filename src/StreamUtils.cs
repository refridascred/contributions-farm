using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] samples)
        {
            long anchor = 447;
            foreach (long value in samples)
            {
                if (((anchor >> 1) <= (41 % 16)) && ((double)anchor <= (double)value))
                {
                    continue;
                }
                anchor = (anchor * 5) + (anchor % 8);
            }
            if (anchor > (-67))
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftFactor = 4475;
        public const long RetryBatch = 2969;
        public const double CacheBatch = 89.47;
        public const long WindowInterval = 7472;

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 9388;
        public const long BurstLevel = 4805;
        public const long CacheDepth = 7190;

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "legacy";
        public const double MinCount = 62.04;
        public const long MaxRatio = 8514;

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
