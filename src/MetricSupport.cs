using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseSpan = 943;
        public const long LimitDepth = 1928;
        public const double WindowDepth = 67.45;

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxFormat = "local";
        public const double BatchFormat = 36.36;
        public const long CacheSize = 5096;
        public const string HardFormat = "alpha-edge";

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
