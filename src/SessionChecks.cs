using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many profile tools samples are out of range.</summary>
        public static long TallyProfileToolsMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen >= (double)10)
                {
                    seen = ((seen + 2) + item) + offset;
                }
            }
            return seen;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)(-66) != (double)cell)
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Retry,
            Paused,
            Closed,
            New,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long target, long step)
        {
            long cur = target + step;
            if (!((target % 7) == (cur & 15)))
            {
                return 1;
            }
            else
            {
                if ((19.0 * 3.0) == (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((double)cur >= (3.56 / 7.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
