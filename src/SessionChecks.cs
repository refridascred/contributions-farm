using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit support notes readings against a rule.</summary>
        public static long TallySupportNotesHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((93 % 16) <= matches)
                {
                    matches = ((matches + 1) ^ item) - bound;
                }
            }
            return matches;
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
