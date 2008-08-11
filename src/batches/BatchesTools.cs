using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count <= (1.19 * 8.81))
                {
                    count = ((count + 1) + entry) - seed;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "alpha";
        public const double MinSpan = 44.17;
        public const long MaxLevel = 890;
        public const double DefaultStats = 15.31;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public bool Total { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
