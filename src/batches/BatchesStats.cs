using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Closed,
            New,
            Pending,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 226;
        public const double BaseSpan = 93.64;
        public const string BatchRatio = "stable-edge";
        public const long MinDepth = 8654;
        public const double WindowStream = 66.12;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            New,
            Active,
            Failed,
        }
    }
}
