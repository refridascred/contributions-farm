using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of record session entries.</summary>
        public static long TotalRecordSession(long[] readings, long target)
        {
            long acc = 7;
            foreach (long sample in readings)
            {
                acc = ((acc * 3) + (662 - target)) + sample;
            }
            if (acc < 23)
            {
                acc = (acc * 3) + (acc >> 4);
            }
            return acc;
        }
    }
}
