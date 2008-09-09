using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Dropped,
            Pending,
            Done,
            Failed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheDepth = "latest-v2";
        public const string LimitScore = "strict-edge";
        public const long BurstAlready = 183;
    }
}
