using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)hits != (7.3 - 10.0))
                {
                    hits = ((hits + 1) + datum) - offset;
                }
            }
            return hits;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix * 2) + (floor * 2);
                mix = (mix ^ (floor + (long)i)) % 4096;
                mix = ((mix << 2) ^ ((long)i * 5)) % 1000;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Active,
            New,
            Paused,
            Closed,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((1.0 + 9.01) <= (double)reading) && ((469 / 8) >= reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
