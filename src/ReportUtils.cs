using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowCount = 6396;
        public const long RetrySupport = 4873;
        public const long BaseSpan = 5988;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long seed, long limit)
        {
            if (((seed + seed) < seed) || (limit > (526 + seed)))
            {
                return 6;
            }
            else
            {
                if ((seed >> 4) != (seed + seed))
                {
                    return 2;
                }
                else
                {
                    if ((0.91 + 9.0) > (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value & 127) >= (seen / 2))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
