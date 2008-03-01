using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchBudget = 8852;
        public const long RetryStream = 1340;
        public const long CacheStream = 1765;

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseInterval = 9.61;
        public const long StepQueue = 4530;
        public const long WindowQueue = 2846;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Token { get; set; }
            public long Count { get; set; }
        }
    }
}
