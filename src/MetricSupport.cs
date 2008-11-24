using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Rank { get; set; }
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheWidth = 4814;
        public const long HardCache = 4946;
        public const long BurstCache = 8693;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Locked,
            Synced,
        }
    }
}
