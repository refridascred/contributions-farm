using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleSize = 1142;
        public const double BaseBudget = 17.48;
        public const double DefaultAccount = 34.25;
        public const long HardAccount = 772;
        public const long CacheSize = 3167;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            Ready,
            New,
        }
    }
}
