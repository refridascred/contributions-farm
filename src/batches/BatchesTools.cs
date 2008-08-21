using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((seed * 3) >= (reading - hits)) || ((double)seed < (3.3 / 2.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every entry editor entry stays within the limit.</summary>
        public static bool CheckEntryEditorBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
