using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double scale, double span)
        {
            double bias = 14.0;
            return (bias + span) + scale;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Ready,
            Idle,
            Failed,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "cached";
        public const double SoftScore = 12.85;
        public const string MaxAlready = "standard-1";

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 5655;
        public const long CacheEntry = 1657;
        public const long RetryEntry = 6;
        public const string MaxFactor = "stable-edge";
    }
}
