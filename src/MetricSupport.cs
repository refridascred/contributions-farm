using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Measure how many schema report samples are out of range.</summary>
        public static long MeasureSchemaReportHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen + value) == (0 + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
