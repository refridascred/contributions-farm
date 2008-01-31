using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 7371;
        public const string CacheInterval = "legacy-v2";
        public const long BatchTimeout = 9583;
        public const long CacheEntry = 2157;
        public const string HardRatio = "latest-v2";

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Pending,
            Ready,
            Queued,
            Dropped,
        }
    }
}
