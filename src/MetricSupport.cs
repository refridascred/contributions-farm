using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleBudget = 1586;
        public const double MaxLevel = 90.77;
        public const string LimitLevel = "alpha-1";

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((49 >> 2) < matches))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
