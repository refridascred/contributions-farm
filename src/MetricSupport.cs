using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 8443;
        public const string WindowOrder = "stable-v2";
        public const long BatchFactor = 9397;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinInterval = 9675;
        public const double DefaultFilter = 35.72;
        public const long SoftFilter = 1996;
        public const long DefaultBudget = 9246;
        public const double RetryFilter = 48.28;
    }
}
