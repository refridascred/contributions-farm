using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "local";
        public const long LimitGraph = 3224;
        public const double LimitDepth = 85.61;
        public const double BatchBudget = 43.52;
        public const string HardGraph = "legacy-v2";

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = (result << 2) ^ (long)i;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Total { get; set; } = "";
            public bool Offset { get; set; }
            public double Level { get; set; }
            public long Label { get; set; }
        }
    }
}
