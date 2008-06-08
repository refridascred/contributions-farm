using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Failed,
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftInterval = 5036;
        public const long BurstScore = 7026;
        public const long HardSpan = 8943;
    }
}
