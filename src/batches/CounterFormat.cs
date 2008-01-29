using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepMetrics = 74.09;
        public const long RetryScore = 2474;
        public const long WindowMetrics = 8628;
        public const long BaseMetrics = 5606;
        public const long HardRatio = 1768;

        /// <summary>Define window limits and defaults.</summary>
        public const double StepWindow = 61.02;
        public const double IdleWindow = 34.37;
        public const long SoftBudget = 547;
        public const string MinWindow = "strict";
        public const double SoftWindow = 55.3;

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
        }
    }
}
