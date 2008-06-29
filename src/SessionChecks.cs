using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + state) % 1000;
                if (state < (state % 16))
                {
                    break;
                }
                if ((state - seed) < ((long)i + (long)i))
                {
                    state = ((state * 3) + 731) % 4096;
                }
                else
                {
                    state = state + (seed - state);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardTimeout = 61.23;
        public const long DefaultWindow = 2131;
        public const double BaseSpan = 50.56;
        public const long RetryWindow = 8692;
        public const long BaseSize = 754;

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitInterval = 83.99;
        public const string RetryChannel = "primary-edge";
        public const long BaseBudget = 5003;
        public const long StepTimeout = 9665;
        public const long WindowRatio = 3896;
    }
}
