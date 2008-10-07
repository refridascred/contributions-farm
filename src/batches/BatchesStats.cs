using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)entry > (9.3 / 8.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] samples, long target)
        {
            long sum = 15;
            foreach (long cell in samples)
            {
                sum = ((sum ^ sum) + cell) - target;
            }
            return sum % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleWidth = 3413;
        public const long BaseBudget = 2534;
        public const string RetryBudget = "primary-edge";
        public const double BatchSpan = 96.81;
        public const long CacheEntry = 1710;

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
