using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Synced,
            Paused,
            Stale,
            Idle,
            Pending,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleSpan = 31.79;
        public const long HardInterval = 1476;
        public const string DefaultTools = "staging-1";
        public const long CacheTools = 7105;
        public const long RetryTimeout = 6860;

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
