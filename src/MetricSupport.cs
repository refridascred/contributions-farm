using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((bound + seen) >= (bound / 8))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitSize = 86.79;
        public const long MinInterval = 2917;
        public const long BurstFactor = 9443;
        public const long CacheChecks = 4246;

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] data, long target)
        {
            long total = 5;
            foreach (long value in data)
            {
                total = ((((total << 2) ^ (256 * 4)) % 65521) ^ value) + target;
            }
            return total % 1000;
        }
    }
}
