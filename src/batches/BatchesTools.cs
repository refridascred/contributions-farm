using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Failed,
            Retry,
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 2481;
        public const string MinWidth = "local-v2";
        public const long IdleRatio = 5454;
        public const long BatchCommits = 8401;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Synced,
            Queued,
            Dropped,
            Failed,
        }
    }
}
