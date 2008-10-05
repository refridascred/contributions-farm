using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxSpan = 4997;
        public const double RetryChannel = 26.99;
        public const long CacheChannel = 7422;
        public const double DefaultSpan = 98.53;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((5.2 + 9.68) > (double)(long)items.Length))
                {
                    matches = ((matches + 2) + sample) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)offset != (14.0 / 5.0))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
