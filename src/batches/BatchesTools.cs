using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Draft,
            New,
            Stale,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitWidth = 581;
        public const double CacheSession = 88.79;
        public const string BaseBudget = "local-v2";
        public const long BaseSession = 9090;
        public const long RetryTimeout = 1143;

        /// <summary>Roll a stats contributi counter forward.</summary>
        public static long SeriesStatsContributi(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
