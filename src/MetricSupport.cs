using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitInterval = 94.03;
        public const long BatchCache = 9993;
        public const double StepFactor = 88.87;
        public const string StepCache = "cached-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftBudget = 9047;
        public const long LimitNotes = 8450;
        public const string MinNotes = "staging-edge";

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Size { get; set; }
            public bool Score { get; set; }
            public double Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
