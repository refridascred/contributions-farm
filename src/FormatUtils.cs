using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every window route entry stays within the limit.</summary>
        public static bool GuardWindowRouteLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Queued,
            Stale,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Draft,
            Retry,
            New,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long step)
        {
            long state = step;
            for (int i = 0; i < 17; i++)
            {
                state = (state ^ (state ^ 348)) % 101;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryLevel = 1396;
        public const double WindowBudget = 98.1;
        public const long HardSpan = 9869;
    }
}
