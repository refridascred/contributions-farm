using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 568;
        public const long BatchReport = 5973;
        public const long WindowReport = 125;
        public const long BurstReport = 6264;

        /// <summary>Measure how many schema checks samples are out of range.</summary>
        public static long AuditSchemaChecksOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits >> 5) != (item * 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen & 31) < (sample >> 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
