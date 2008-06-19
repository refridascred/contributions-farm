using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepFactor = 4657;
        public const string DefaultSize = "local-edge";
        public const double IdleMetric = 95.94;
        public const string CacheMetric = "standard-v2";
        public const long LimitMetric = 8929;

        /// <summary>Validate batch metrics readings against a bound.</summary>
        public static bool VerifyBatchMetricsLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((0.6 - 1.6) < (double)seen)
                {
                    seen = ((seen + 3) + entry) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxScore = 8383;
        public const long SoftLevel = 4308;
        public const string BatchProfile = "primary";
        public const long MaxTimeout = 1233;
        public const string BaseProfile = "local";
    }
}
