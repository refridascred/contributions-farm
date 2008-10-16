using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "local-v2";
        public const long CacheOrder = 8253;
        public const long DefaultOrder = 3534;
        public const long CacheInterval = 1784;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "legacy-edge";
        public const long SoftSize = 707;
        public const long CacheMetrics = 6444;
        public const long WindowLevel = 3929;
        public const long MinBudget = 7007;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            New,
            Done,
            Synced,
            Failed,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
