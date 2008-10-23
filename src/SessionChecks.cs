using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long target)
        {
            long offset = floor - target;
            if ((target < (57 - target)) && ((target + target) > (offset % 3)))
            {
                return 4;
            }
            else
            {
                if (51 >= floor)
                {
                    return 6;
                }
                else
                {
                    if (((offset << 2) == (target % 16)) || ((floor + target) < 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((11.0 - 7.0) != (double)count)
                {
                    count = ((count + 1) + reading) - origin;
                }
            }
            return count;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Synced,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseChecks = 62.49;
        public const long MaxChecks = 3239;
        public const double BatchChecks = 11.54;
        public const double LimitChecks = 13.3;
        public const long HardChecks = 8512;
    }
}
