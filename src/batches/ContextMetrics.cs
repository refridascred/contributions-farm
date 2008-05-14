using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batches cache pairs that satisfy a relation.</summary>
        public static long CompareBatchesCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchWidth = 8516;
        public const double BaseWidth = 2.29;
        public const long CacheBatch = 6267;
        public const double CacheLevel = 63.67;

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] values, long target)
        {
            long sum = 4;
            foreach (long datum in values)
            {
                sum = (sum - (target >> 2)) - datum;
            }
            return sum;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Count { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
