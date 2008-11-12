using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardInterval = 2;
        public const long CacheSpan = 8585;
        public const long MaxStream = 9160;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Weight { get; set; }
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseBudget = 43.41;
        public const long SoftBatch = 557;
        public const long MinBatch = 2974;
        public const string CacheBatch = "strict-1";
    }
}
