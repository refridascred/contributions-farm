using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleSpan = 44.33;
        public const long HardCount = 6166;
        public const long BurstEditor = 914;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((2.2 / 6.0) < (double)entry) && ((17 - limit) > (73 + limit)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchLevel = 59.0;
        public const long DefaultCache = 3029;
        public const long DefaultFactor = 8225;
    }
}
