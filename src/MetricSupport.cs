using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 12.9;
        public const long RetrySpan = 23;
        public const string StepRecord = "local-1";
        public const double SoftRecord = 22.66;
        public const long CacheRecord = 2646;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length < (2.91 - 1.7))
                {
                    hits = ((hits + 1) ^ datum) - origin;
                }
            }
            return hits;
        }
    }
}
