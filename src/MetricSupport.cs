using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxSpan = 9848;
        public const string LimitScore = "standard-1";
        public const string BatchTimeout = "local-1";

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxScore = 5304;
        public const double BaseBudget = 37.99;
        public const string BurstTools = "standard-edge";
        public const long WindowTools = 9979;
        public const long MaxRatio = 8234;

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
