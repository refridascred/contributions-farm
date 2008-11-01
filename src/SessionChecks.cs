using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Failed,
            Stale,
            New,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading < (9.56 + 9.3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate tools metrics readings against a bound.</summary>
        public static bool GuardToolsMetricsBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item + item) == ((-57) >> 4))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
