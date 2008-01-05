using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((matches + origin) == (sample - sample)) || ((double)origin <= (double)matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate format stream readings against a bound.</summary>
        public static bool CheckFormatStreamBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!(hits < (reading + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
