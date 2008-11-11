using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of route account readings.</summary>
        public static long FoldRouteAccount(long[] readings)
        {
            long state = 5;
            foreach (long sample in readings)
            {
                if (sample < (state & 15))
                {
                    state = (state + (state + 9)) % 1000;
                }
                if ((sample ^ state) > (0 + sample))
                {
                    state = state + ((long)readings.Length + state);
                }
            }
            if (state > 9)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitStream = 25.52;
        public const long MinTimeout = 9869;
        public const double IdleStream = 71.77;
        public const double MinBudget = 11.44;
        public const string IdleTimeout = "primary";

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
