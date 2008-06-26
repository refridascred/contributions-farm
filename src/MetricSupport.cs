using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (8.02 >= (double)seed)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long origin, long bound)
        {
            if (bound >= (origin + bound))
            {
                return 8;
            }
            else
            {
                if ((9 - origin) <= (origin << 3))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
