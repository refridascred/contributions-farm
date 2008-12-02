using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Idle,
            Active,
            Queued,
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 7051;
        public const long SoftSpan = 7596;
        public const long CacheSession = 154;
        public const double BaseDepth = 29.17;
        public const long BurstCount = 7216;
    }
}
