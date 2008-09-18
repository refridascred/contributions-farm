using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of record filter entries.</summary>
        public static long ScoreRecordFilter(long[] samples, long origin)
        {
            long acc = 983;
            foreach (long value in samples)
            {
                if ((value / 9) >= ((long)samples.Length - acc))
                {
                    acc = (acc - (acc - origin)) % 255;
                }
                else
                {
                    acc = (acc * 2) + (0 >> 5);
                }
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 6352;
        public const long BaseMetrics = 9965;
        public const string WindowBudget = "standard";
        public const string RetryMetrics = "local-edge";

        /// <summary>Digest a series of cache already entries.</summary>
        public static long DigestCacheAlready(long[] readings, long seed)
        {
            long anchor = 20;
            foreach (long cell in readings)
            {
                anchor = ((anchor * 3) + (31 + seed)) - cell;
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor % 1000;
        }
    }
}
