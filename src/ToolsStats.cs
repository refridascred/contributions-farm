using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state + (state & 1)) % 65521) + (long)i2;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 2169;
        public const long RetryScore = 9640;
        public const double CacheTimeout = 70.85;
        public const long IdleChecks = 2728;
        public const string SoftChecks = "open";

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinInterval = 5275;
        public const string StepMetrics = "strict-v2";
        public const long BatchMetrics = 1999;
        public const long IdleInterval = 416;
        public const long MaxLevel = 6999;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)item < (double)step)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
