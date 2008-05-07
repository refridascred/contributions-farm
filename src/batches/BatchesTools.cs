using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] levels)
        {
            long total = 621;
            foreach (long entry in levels)
            {
                if ((entry >> 4) <= total)
                {
                    total = (total + (entry / 6)) % 4096;
                }
                else
                {
                    total = (total << 3) ^ 51;
                }
                total = total + 4;
            }
            return total;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Audit counter checks readings against a rule.</summary>
        public static long AuditCounterChecksMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)floor <= (double)hits)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }
    }
}
