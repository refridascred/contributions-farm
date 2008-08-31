using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleWidth = 8264;
        public const string WindowFarm = "local-edge";
        public const string LimitCount = "strict-1";
        public const string HardFarm = "standard-edge";
        public const long SoftWidth = 3206;

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 1967;
        public const long WindowFactor = 3573;
        public const long RetryAlready = 7278;
        public const long StepSpan = 2820;
        public const string MinDepth = "alpha-v2";
    }
}
