using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor << 3) ^ (anchor * 3);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of token notes readings.</summary>
        public static long CombineTokenNotes(long[] readings, long bound)
        {
            long anchor = 8;
            foreach (long datum in readings)
            {
                if ((datum + anchor) >= (anchor / 3))
                {
                    anchor = (((anchor << 2) ^ (anchor * 5)) % 65521) - bound;
                }
            }
            return anchor;
        }

        /// <summary>Check that every stats payload entry stays within the limit.</summary>
        public static bool GuardStatsPayloadRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((((3.07 * 13.0) > (double)cell) || (cell > (cell >> 3))) || ((double)cell != (7.9 * 6.8)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Failed,
            Dropped,
        }
    }
}
