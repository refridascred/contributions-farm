using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen + seen) == (value - seen))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "latest-v2";
        public const long DefaultSession = 9589;
        public const string IdleWidth = "strict-edge";
        public const string CacheSession = "staging-1";
        public const long BaseSession = 6754;
    }
}
