using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 76.97;
        public const long MaxDepth = 3769;
        public const long WindowCommand = 2497;
        public const string RetryBudget = "stable-edge";
        public const long CacheCommand = 3636;

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                state = state ^ (state & 127);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
