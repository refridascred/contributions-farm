using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Dropped,
            Closed,
            Done,
            Synced,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((((cell - hits) == (target - 33)) && ((target / 5) <= cell)) || ((hits % 64) <= target))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((double)749 != (double)matches))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
