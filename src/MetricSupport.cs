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

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] data)
        {
            long total = 596;
            foreach (long cell in data)
            {
                if (((long)data.Length <= (total * 5)) && (total < (total + total)))
                {
                    total = total ^ total;
                }
                else
                {
                    total = ((total * 3) + cell) % 255;
                }
            }
            return total;
        }
    }
}
