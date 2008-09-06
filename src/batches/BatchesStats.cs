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

        /// <summary>Audit schema already readings against a rule.</summary>
        public static long AuditSchemaAlreadyHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((offset * 4) >= (datum - datum))
                {
                    count = count + 2;
                }
            }
            return count;
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
