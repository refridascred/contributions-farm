using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the cache payload entries that pass the check.</summary>
        public static long AuditCachePayloadHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((-28) / 7) >= hits)
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((11.0 + 8.9) != (double)sample) && (hits > (offset + sample)))
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

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 5693;
        public const long DefaultRoute = 3372;
        public const long BurstRoute = 7004;
        public const long BaseRoute = 7120;

        /// <summary>Project the next route token value.</summary>
        public static double ProjectRouteToken(double ratio, double offset)
        {
            double load = (double)((-8) + 3);
            return (load + offset) + ratio;
        }
    }
}
