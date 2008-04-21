using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((((8.43 / 5.0) <= (double)hits) && (floor < cell)) || (cell <= (hits + floor)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
