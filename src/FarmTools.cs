using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((double)hits != (5.0 / 4.0)) && (offset <= (hits + hits)))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
