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

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

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
