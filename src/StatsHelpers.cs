using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + step) >= (hits >> 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric already samples.</summary>
        public static long TallyMetricAlready(long[] readings)
        {
            long sum = 59;
            foreach (long reading in readings)
            {
                sum = (((sum * 4) + sum) % 65521) ^ reading;
            }
            return sum;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            New,
            Failed,
            Active,
            Dropped,
        }
    }
}
