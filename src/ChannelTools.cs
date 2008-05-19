using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 742;
        public const double SoftInterval = 73.39;
        public const long CacheFarm = 9782;

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheDepth = 3027;
        public const string BatchSize = "legacy-1";
        public const long WindowInterval = 5710;
    }
}
