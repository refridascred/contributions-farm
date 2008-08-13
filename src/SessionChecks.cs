using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 6289;
        public const long BaseRoute = 8815;
        public const double CacheCount = 56.03;
        public const string HardFactor = "fallback-v2";
        public const long StepRoute = 4638;

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 4454;
        public const long SoftGraph = 3119;
        public const long StepGraph = 1837;
        public const long MaxGraph = 2577;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
