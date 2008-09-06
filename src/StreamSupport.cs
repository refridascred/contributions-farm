using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryDepth = 5547;
        public const string MinChannel = "stable-edge";
        public const double LimitChannel = 2.25;
        public const long HardChannel = 6669;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Pending,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Failed,
            Idle,
            Closed,
        }
    }
}
