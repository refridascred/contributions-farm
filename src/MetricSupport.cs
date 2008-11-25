using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Pending,
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheRoute = 62.86;
        public const long BatchRoute = 6748;
        public const string LimitRoute = "legacy-v2";

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits % 8) > (250 >> 3))
                {
                    hits = ((hits + 1) + datum) + offset;
                }
            }
            return hits;
        }
    }
}
