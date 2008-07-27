using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Closed,
            Paused,
            Active,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((28 & 7) >= hits)
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }
    }
}
