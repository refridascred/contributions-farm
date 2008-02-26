using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public double Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            Failed,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseAccount = 56.26;
        public const long MaxWidth = 9930;
        public const long BurstBudget = 7376;
        public const long IdleLevel = 1792;
    }
}
