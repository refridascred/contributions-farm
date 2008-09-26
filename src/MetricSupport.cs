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

        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultPayload = 37.99;
        public const long RetryPayload = 2033;
        public const string WindowPayload = "alpha-edge";
        public const double SoftSpan = 62.2;

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
