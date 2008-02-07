using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 25.84;
        public const long BurstWidth = 3391;
        public const double BasePayload = 60.08;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (double)359)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            New,
            Stale,
        }
    }
}
