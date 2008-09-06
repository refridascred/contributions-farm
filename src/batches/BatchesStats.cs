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

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySpan = 5500;
        public const long SoftTimeout = 349;
        public const string RetrySchema = "primary-v2";
        public const string BurstCount = "legacy-1";

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
