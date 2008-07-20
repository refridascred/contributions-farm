using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseScore = "alpha-edge";
        public const string WindowFactor = "legacy-v2";
        public const double CacheSchema = 61.61;

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseInterval = "strict-1";
        public const long BatchRatio = 1035;
        public const double MinLevel = 14.41;
        public const string HardContext = "alpha";
        public const long IdleFactor = 6958;
    }
}
