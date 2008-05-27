using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 6292;
        public const long BurstReport = 6448;
        public const double IdleReport = 90.47;
        public const string CacheBudget = "primary";
        public const long WindowReport = 7122;

        /// <summary>Define session limits and defaults.</summary>
        public const double BurstTimeout = 2.2;
        public const string CacheSession = "strict-v2";
        public const long BurstSession = 9347;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((((seen % 2) < (offset + datum)) && (seen <= (seen + seen))) && ((double)datum < (10.0 - 0.4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
