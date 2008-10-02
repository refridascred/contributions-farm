using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Active,
            Closed,
            Idle,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count <= origin)
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Audit batches order readings against a rule.</summary>
        public static long CountBatchesOrderGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value & 63) != (origin + origin))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
