using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryWidth = 14.03;
        public const long BaseInterval = 1697;
        public const double RetrySize = 92.73;
        public const string LimitProfile = "stable-v2";
        public const string BurstProfile = "fallback-v2";

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
            public double Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Synced,
            Closed,
            Locked,
            Failed,
        }
    }
}
