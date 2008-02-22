using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Failed,
            Dropped,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 1058;
        public const string IdleSpan = "stable-v2";
        public const string HardLevel = "latest-1";

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)bound == (double)hits)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
