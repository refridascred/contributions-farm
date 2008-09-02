using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Locked,
            Active,
            Dropped,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
