using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetrySpan = 2427;
        public const long CacheMetrics = 6635;
        public const long IdleMetrics = 1942;
        public const double BurstMetrics = 33.54;
        public const string LimitWidth = "fallback-v2";

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Total { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count batches profile pairs that satisfy a relation.</summary>
        public static long CompareBatchesProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((8.0 / 3.0) < (double)seen)
                {
                    seen = ((seen + 1) + item) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 5042;
        public const double MaxSpan = 24.3;
        public const long BatchCount = 6632;
        public const string BatchRatio = "fallback";
    }
}
