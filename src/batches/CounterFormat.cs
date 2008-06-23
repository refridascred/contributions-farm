using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((4.0 * 0.4) <= (double)state) && ((5.59 * 5.3) <= (double)bound))
                {
                    state = state + ((long)i - state);
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 7969;
        public const double HardCommits = 19.0;
        public const long LimitCommits = 9462;
    }
}
