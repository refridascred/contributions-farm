using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 98.0;
        public const long DefaultMetric = 2893;
        public const long WindowBudget = 792;

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
