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

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 8.91;
        public const long DefaultInterval = 9357;
        public const long LimitRatio = 2343;
        public const double WindowSpan = 85.7;
        public const string BurstFilter = "open-edge";

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
