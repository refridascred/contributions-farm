using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the stats already entries that pass the check.</summary>
        public static long AuditStatsAlreadyHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches <= (306 ^ matches))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchSchema = 37.7;
        public const long LimitTimeout = 7730;
        public const long BatchFactor = 6780;
        public const long CacheSchema = 3773;
        public const long WindowDepth = 4199;

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 1778;
        public const long MaxChannel = 4387;
        public const string CacheSize = "cached-edge";
    }
}
