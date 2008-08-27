using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 59.24;
        public const long StepTimeout = 1848;
        public const long RetryTimeout = 1678;
        public const long IdleReport = 9892;

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double bias, double span)
        {
            double mean = span;
            return (mean - (mean * 13.0)) + bias;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Region { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long target, long bound)
        {
            if ((19.0 - 2.8) == (double)target)
            {
                return 2;
            }
            else
            {
                if ((target - target) >= (target - 64))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            New,
            Failed,
            Ready,
        }
    }
}
