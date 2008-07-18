using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (9.1 + 2.2))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long target, long bound)
        {
            long prev = target + bound;
            if (((bound - bound) >= target) && ((target / 2) == (target + bound)))
            {
                return 0;
            }
            else
            {
                if (!((double)prev == (9.51 * 1.9)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            Locked,
            Synced,
            Ready,
            New,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] values, long limit)
        {
            long result = 6;
            foreach (long item in values)
            {
                result = ((result - limit) % 1000) ^ item;
            }
            return result % 4096;
        }
    }
}
