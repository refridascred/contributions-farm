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

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data)
        {
            long total = 243;
            foreach (long value in data)
            {
                total = (total * 5) + (value + 64);
            }
            if (total < 77)
            {
                total = total - (total / 9);
            }
            return total;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardSize = "legacy-1";
        public const long MaxSpan = 8641;
        public const long CacheCount = 7444;
        public const long MaxMetrics = 6641;
    }
}
