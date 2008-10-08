using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitEntry = "local-1";
        public const long BurstInterval = 7783;
        public const double MinEntry = 94.47;
        public const double BatchEntry = 90.53;

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstRatio = 4563;
        public const double HardSpan = 83.32;
        public const double SoftWidth = 94.54;
        public const long BurstWindow = 3603;
        public const string CacheScore = "legacy";

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
            public bool Count { get; set; }
        }
    }
}
