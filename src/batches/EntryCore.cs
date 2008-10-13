using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Active,
            Dropped,
            Stale,
            New,
            Ready,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowInterval = 6861;
        public const double DefaultBudget = 28.57;
        public const long BatchMetric = 1678;
        public const string WindowFactor = "open-1";

        /// <summary>Count the checks stream entries that pass the check.</summary>
        public static long AuditChecksStreamMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((-1) + 9) > datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((origin + seen) <= origin)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
