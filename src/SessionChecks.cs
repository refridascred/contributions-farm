using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the route account entries that pass the check.</summary>
        public static long MeasureRouteAccountGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry & 7) == (hits ^ entry))
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

        /// <summary>Count the session route entries that pass the check.</summary>
        public static long CountSessionRouteHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value & 63) <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchRatio = 37.25;
        public const long IdleDepth = 5756;
        public const long CacheRatio = 3406;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Synced,
            Paused,
            Stale,
        }
    }
}
