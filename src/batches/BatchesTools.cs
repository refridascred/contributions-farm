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

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 9223;
        public const double DefaultDepth = 80.32;
        public const double BatchBudget = 32.77;
        public const double IdleSpan = 29.3;
    }
}
