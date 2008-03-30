using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Idle,
            Closed,
            Locked,
            Done,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "alpha-edge";
        public const long BaseCommand = 8317;
        public const long CacheCommand = 9888;
        public const string IdleRatio = "stable-1";
        public const string CacheRatio = "alpha-1";

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
