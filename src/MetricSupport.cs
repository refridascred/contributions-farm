using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Stale,
            Closed,
            Ready,
            Paused,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 2696;
        public const long LimitSession = 3215;
        public const long CacheLevel = 7446;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Weight { get; set; }
            public double Limit { get; set; }
        }
    }
}
