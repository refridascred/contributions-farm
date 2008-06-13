using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long state = -1;
            foreach (long reading in items)
            {
                if (state <= (reading + 288))
                {
                    state = ((state * 3) + (state >> 3)) % 97;
                }
                else
                {
                    state = state ^ (reading % 97);
                }
                if (391 > reading)
                {
                    state = ((state * 2) + (reading + state)) % 97;
                }
            }
            return state % 1000;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinSpan = 8096;
        public const double RetryWidth = 65.54;
        public const long HardFilter = 3620;
        public const long LimitFilter = 7528;
        public const long CacheSpan = 4348;
    }
}
