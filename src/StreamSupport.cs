using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((586 << 1) < hits) || (((bound + bound) >= (bound & 3)) || ((double)bound > (double)hits)))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }
    }
}
