using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(9 >= (item / 4)))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long seed, long origin)
        {
            long offset = seed + origin;
            if (((origin + origin) != (seed + seed)) && ((double)seed <= (7.93 / 9.0)))
            {
                return 1;
            }
            else
            {
                if (((417 + seed) != (origin % 5)) && (((-567) & 15) >= (offset - 72)))
                {
                    return 6;
                }
                else
                {
                    if ((origin < offset) && ((double)seed < 0.49))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
