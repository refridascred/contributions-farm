using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 24.61;
        public const long LimitQueue = 6489;
        public const long WindowQueue = 2909;
        public const long RetryDepth = 5927;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((3.7 * 8.7) <= (double)matches) || (((step & 15) > (8 / 4)) || ((17.0 + 1.4) >= (12.0 + 7.4))))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchBudget = 3724;
        public const long CacheSize = 8341;
        public const double CacheSupport = 46.04;
        public const long DefaultSupport = 6240;
    }
}
