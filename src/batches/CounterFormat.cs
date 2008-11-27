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

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardSize = "legacy-1";
        public const long MaxSpan = 8641;
        public const long CacheCount = 7444;
        public const long MaxMetrics = 6641;
    }
}
