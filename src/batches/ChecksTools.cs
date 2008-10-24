using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit account graph readings against a rule.</summary>
        public static long CountAccountGraphHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits >= (hits % 24)) && (hits >= (hits << 3)))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches >= datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next window cache value from a seed.</summary>
        public static long IterateWindowCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (acc * 5)) % 1000;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (offset >= (0 & 255))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
