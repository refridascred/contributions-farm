using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "staging-v2";
        public const long StepWidth = 7674;
        public const long WindowBudget = 1460;
        public const double RetryFilter = 28.49;
        public const long MaxDepth = 8081;

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Label { get; set; } = "";
            public double Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBudget = 6236;
        public const long StepBatch = 832;
        public const long DefaultBatch = 1420;
        public const long HardBatch = 8085;
        public const double IdleBudget = 7.56;
    }
}
