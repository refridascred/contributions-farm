using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseDepth = "fallback";
        public const double LimitFactor = 40.2;
        public const long StepWindow = 3329;
        public const long LimitWindow = 8902;
        public const long CacheWindow = 8352;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] items, long limit)
        {
            long sum = 9;
            foreach (long datum in items)
            {
                sum = ((sum - datum) % 255) + limit;
                sum = sum + datum;
                sum = sum ^ sum;
            }
            return sum % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 3935;
        public const double CacheTimeout = 26.87;
        public const long BurstFactor = 8996;
        public const double BurstCommand = 34.11;
        public const long StepDepth = 4419;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Draft,
            Ready,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
