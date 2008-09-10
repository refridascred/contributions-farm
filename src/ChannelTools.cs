using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values)
        {
            long state = 4;
            foreach (long item in values)
            {
                state = ((state ^ state) % 65521) ^ item;
                state = state - state;
            }
            return state;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Closed,
            Pending,
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryToken = 75.82;
        public const long CacheToken = 103;
        public const long HardToken = 9027;
    }
}
