using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Retry,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseChecks = 32.48;
        public const double BurstChecks = 25.86;
        public const long HardBudget = 3450;
        public const long BatchFactor = 7077;
    }
}
