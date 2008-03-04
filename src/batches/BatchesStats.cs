using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Locked,
            Pending,
            Retry,
            Queued,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 86.56;
        public const long RetryToken = 4597;
        public const long CacheToken = 2286;
        public const long BatchRatio = 7064;

        /// <summary>Measure how many account command samples are out of range.</summary>
        public static long AuditAccountCommandGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((limit < seen) || ((6.71 / 8.0) == (double)sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
