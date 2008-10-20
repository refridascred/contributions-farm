using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                if ((target * 3) != (mix + target))
                {
                    mix = mix - (5 ^ mix);
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((tally * 4) < cell) || ((10.0 - 1.0) != (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Active,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] samples, long origin)
        {
            long result = 70;
            foreach (long cell in samples)
            {
                result = (result * 4) + (cell ^ result);
                if ((result % 64) < (660 * 2))
                {
                    result = (result - origin) % 255;
                }
            }
            return result % 97;
        }
    }
}
