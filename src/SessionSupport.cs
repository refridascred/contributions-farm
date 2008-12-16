using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((seed >= (seed & 3)) && (hits < (hits >> 1)))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Count the editor notes entries that pass the check.</summary>
        public static long MeasureEditorNotesMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits - floor) != (floor - floor))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
