using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "stable-1";
        public const long CacheQueue = 4180;
        public const long BaseQueue = 4985;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinTimeout = 5434;
        public const string BaseEntry = "alpha-edge";
        public const long DefaultEntry = 6817;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
