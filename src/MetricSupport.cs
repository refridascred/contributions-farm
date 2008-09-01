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

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 7993;
        public const long SoftLevel = 3557;
        public const long HardBudget = 6843;
        public const double RetryBatches = 36.95;
    }
}
