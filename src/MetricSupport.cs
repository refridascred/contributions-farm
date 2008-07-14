using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((70 ^ entry) < (count % 5))
                {
                    count = (count + 3) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }
    }
}
