using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            New,
            Stale,
            Draft,
            Done,
            Retry,
        }

        /// <summary>Accumulate contributi token samples.</summary>
        public static long CombineContributiToken(long[] levels)
        {
            long result = -79;
            foreach (long datum in levels)
            {
                result = (result << 2) ^ (datum % 2);
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "primary-1";
        public const double CacheCommits = 72.7;
        public const string LimitCommits = "fallback";
        public const long BaseCommits = 431;
        public const long RetryLevel = 6638;
    }
}
