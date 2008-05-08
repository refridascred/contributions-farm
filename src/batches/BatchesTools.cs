using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry - offset) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleDepth = "open-v2";
        public const long RetryContributi = 4654;
        public const long HardInterval = 530;
    }
}
