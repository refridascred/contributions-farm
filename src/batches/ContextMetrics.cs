using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchSpan = "standard-edge";
        public const long CacheQueue = 7648;
        public const string RetryQueue = "legacy-v2";
        public const long BatchQueue = 4033;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long offset, long target)
        {
            if ((offset > (offset + target)) || ((double)offset <= (double)offset))
            {
                return 8;
            }
            else
            {
                if ((double)96 != (double)offset)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepTimeout = 4334;
        public const double BurstCluster = 90.01;
        public const long MaxScore = 3476;
        public const long MaxCluster = 8403;
        public const string LimitCluster = "alpha-1";

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
