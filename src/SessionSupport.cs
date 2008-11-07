using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry << 1) >= (hits ^ entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            Synced,
            Pending,
            Draft,
            Stale,
        }
    }
}
