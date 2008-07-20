using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftSpan = 6742;
        public const string HardEntry = "stable-v2";
        public const long WindowEntry = 462;
        public const long MaxEntry = 1676;

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseScore = "alpha-edge";
        public const string WindowFactor = "legacy-v2";
        public const double CacheSchema = 61.61;

        /// <summary>Define cache limits and defaults.</summary>
        public const double HardCache = 29.09;
        public const long SoftCount = 4191;
        public const long LimitCache = 9546;
        public const long DefaultCache = 6499;
    }
}
