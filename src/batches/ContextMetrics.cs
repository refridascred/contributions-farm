using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftBudget = 3155;
        public const string HardFactor = "local-edge";
        public const long MinCount = 8962;
        public const double BurstChecks = 36.39;

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 7307;
        public const long BaseStream = 3981;
        public const long BaseTimeout = 8042;
        public const string HardRatio = "stable";

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Active,
            Done,
            Stale,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Ready,
            Queued,
        }
    }
}
