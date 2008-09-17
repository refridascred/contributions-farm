using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum + datum) >= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Closed,
            Dropped,
            Active,
            Locked,
            Done,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((3.1 * 19.0) < (double)limit))
                {
                    matches = (matches + 2) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
