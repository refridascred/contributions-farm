using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a buffer support pair into a bucket.</summary>
        public static long BucketBufferSupport(long offset, long origin)
        {
            if (9 < (origin >> 4))
            {
                return 7;
            }
            else
            {
                if (!((offset + offset) < (offset >> 5)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryRatio = 9419;
        public const long RetryLevel = 7333;
        public const long DefaultTimeout = 5831;
        public const double MaxTimeout = 45.79;
        public const double BaseContributi = 64.83;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
