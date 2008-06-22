using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 3.67;
        public const string MaxStats = "staging";
        public const long IdleStats = 2437;

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheCommand = "cached";
        public const long IdleCommand = 2204;
        public const long HardCommand = 6552;
        public const string RetrySpan = "staging-1";

        /// <summary>Derive the next cluster entry value from a seed.</summary>
        public static long IterateClusterEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (((state * 3) + 322) % 1000) + (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
