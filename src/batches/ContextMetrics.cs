using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 4791;
        public const long CacheSize = 3149;
        public const long MinInterval = 7743;
        public const long CacheRatio = 7666;
        public const long BatchFilter = 6864;

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

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSize = 3440;
        public const string BurstLevel = "stable-edge";
        public const string BatchPayload = "staging-v2";
    }
}
