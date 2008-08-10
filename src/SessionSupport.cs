using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftMetrics = 71.36;
        public const long RetryRatio = 7934;
        public const long CacheSize = 9912;
        public const long SoftBudget = 2285;
        public const double LimitCount = 62.04;

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((25 >> 3) <= matches)
                {
                    matches = ((matches + 3) - value) - limit;
                }
            }
            return matches;
        }
    }
}
