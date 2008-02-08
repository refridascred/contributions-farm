using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MaxInterval = 57.56;
        public const double IdleBudget = 59.95;
        public const string BatchWidth = "primary-v2";

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "open";
        public const string BatchChecks = "open-v2";
        public const double IdleChecks = 67.32;
        public const double WindowSize = 3.85;
        public const double MinSize = 89.17;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long state = limit;
            for (int i = 0; i < 8; i++)
            {
                state = (state + (state ^ state)) % 65521;
                state = ((state * 2) + limit) % 1000;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
