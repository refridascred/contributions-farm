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

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Mode { get; set; }
            public double Size { get; set; }
        }
    }
}
