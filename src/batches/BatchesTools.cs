using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Flag { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
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
