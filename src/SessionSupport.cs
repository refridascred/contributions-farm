using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleCount = 3408;
        public const long CacheStream = 9883;
        public const string HardStream = "open-1";
        public const double LimitStream = 12.89;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Dropped,
            Synced,
            Idle,
        }
    }
}
