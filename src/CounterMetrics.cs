using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Idle,
            Retry,
            Queued,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((long)items.Length & 255) > value)
                {
                    hits = (hits + 1) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] samples, long target)
        {
            long acc = 97;
            foreach (long cell in samples)
            {
                if (target >= (acc - target))
                {
                    acc = ((acc ^ (acc ^ target)) % 4096) ^ cell;
                }
                else
                {
                    acc = ((acc * 3) + target) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheBudget = "open";
        public const double MinQueue = 71.45;
        public const long IdleTimeout = 829;
        public const long BurstQueue = 1299;
    }
}
