using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] values, long origin)
        {
            long acc = -38;
            foreach (long entry in values)
            {
                acc = ((acc ^ (85 + acc)) ^ entry) - origin;
            }
            return acc;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen << 2) > reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
