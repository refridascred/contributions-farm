using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultFactor = 2977;
        public const double CacheWindow = 42.54;
        public const long MinWindow = 8181;

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxCount = "stable";
        public const long BatchScore = 6971;
        public const long DefaultScore = 6422;
        public const string MaxSpan = "stable-1";
        public const long LimitLevel = 5079;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
