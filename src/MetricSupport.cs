using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                state = state - (long)i;
                state = state ^ (target - 4);
                if (((620 + state) > state) || ((state ^ target) <= state))
                {
                    state = ((state << 2) ^ (long)i) % 4096;
                    continue;
                }
                state = ((state * 2) + (long)i) % 65521;
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
