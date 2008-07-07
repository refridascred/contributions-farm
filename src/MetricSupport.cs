using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 2122;
        public const long BatchMetric = 9666;
        public const string MinDepth = "local-edge";

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches % 3) < (matches - matches))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
