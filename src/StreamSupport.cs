using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Idle,
            Locked,
            Synced,
            Failed,
            Active,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinSpan = "strict";
        public const string CacheSize = "fallback-v2";
        public const double BurstTimeout = 24.01;
        public const long DefaultSpan = 1053;
        public const double MaxScore = 85.58;
    }
}
