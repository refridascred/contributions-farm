using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MaxTimeout = 778;
        public const long RetryAccount = 843;
        public const string IdleAccount = "staging-edge";
        public const long BatchAccount = 2906;

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryChecks = 58.05;
        public const string SoftDepth = "latest-v2";
        public const double CacheChecks = 58.69;
        public const long LimitWidth = 3112;
        public const long MaxRatio = 7842;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Active,
            Idle,
            Dropped,
            Stale,
        }
    }
}
