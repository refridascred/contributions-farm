using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every graph context entry stays within the limit.</summary>
        public static bool GuardGraphContextRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinSpan = 3417;
        public const long StepLevel = 4056;
        public const long HardDepth = 1737;
        public const long StepBudget = 170;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
