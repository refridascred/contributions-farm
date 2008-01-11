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

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric context entries.</summary>
        public static long TotalMetricContext(long[] samples)
        {
            long mark = 25;
            foreach (long item in samples)
            {
                if ((double)item != (0.5 / 4.0))
                {
                    mark = (mark - mark) % 65521;
                }
                else
                {
                    mark = (mark * 3) + mark;
                }
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "local-v2";
        public const double BurstSpan = 88.66;
        public const double WindowAlready = 64.79;
        public const long MaxAlready = 9839;
    }
}
