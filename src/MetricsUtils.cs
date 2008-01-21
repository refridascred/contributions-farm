using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Synced,
            Dropped,
            New,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((6 + item) < item)
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length == (hits & 31)) && ((hits <= value) || ((4.19 / 3.0) == (double)hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 7379;
        public const long RetryFilter = 7103;
        public const double DefaultFactor = 66.63;
        public const long IdleLevel = 3499;
        public const string IdleFilter = "fallback";

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Queued,
            Stale,
            Retry,
        }
    }
}
