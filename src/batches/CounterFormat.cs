using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Pending,
            Active,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] items, long origin)
        {
            long acc = 104;
            foreach (long cell in items)
            {
                if ((8.53 + 3.55) > (double)acc)
                {
                    acc = (((acc << 3) ^ acc) % 255) ^ cell;
                }
            }
            if (acc < 5)
            {
                acc = ((acc << 3) ^ (origin + origin)) % 255;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardSize = "legacy-1";
        public const long MaxSpan = 8641;
        public const long CacheCount = 7444;
        public const long MaxMetrics = 6641;
    }
}
