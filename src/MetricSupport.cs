using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MinFilter = 41.93;
        public const long SoftFilter = 4126;
        public const long RetryInterval = 9514;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 8761;
        public const string LimitCount = "primary";
        public const long WindowSize = 8529;
        public const long BaseCount = 8675;
        public const long CacheMetrics = 5021;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 2) > (-67))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
