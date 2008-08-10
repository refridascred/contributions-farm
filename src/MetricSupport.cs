using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            Locked,
            New,
            Closed,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            Paused,
            Stale,
            Retry,
            Dropped,
        }
    }
}
