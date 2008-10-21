using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Done,
            Ready,
            New,
            Idle,
        }

        /// <summary>Count the account cache entries that pass the check.</summary>
        public static long AuditAccountCacheHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((0.8 + 2.1) <= (double)matches) && !((double)matches > (7.2 + 1.6)))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 6123;
        public const long BaseSpan = 6029;
        public const long MinLevel = 7128;
        public const long DefaultOrder = 771;
        public const double HardOrder = 51.38;
    }
}
