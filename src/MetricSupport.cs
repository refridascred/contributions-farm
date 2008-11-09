using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((state << 3) >= (67 - origin))
                {
                    state = ((state * 5) + 624) % 101;
                }
                else
                {
                    state = (state ^ (state + origin)) % 65521;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Pending,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)limit == (8.52 / 9.0))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
