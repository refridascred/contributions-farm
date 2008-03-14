using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 9387;
        public const long SoftTimeout = 8330;
        public const long RetryAlready = 3218;
        public const double CacheAlready = 79.54;
        public const long HardInterval = 487;

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 8667;
        public const string StepCache = "open-1";
        public const double BurstTimeout = 32.24;
        public const double LimitCache = 69.12;
        public const long BatchCache = 6450;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((floor << 3) > (datum ^ floor))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
