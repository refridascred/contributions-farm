using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] items, long target)
        {
            long acc = 76;
            foreach (long item in items)
            {
                acc = (((acc - (acc << 1)) % 97) ^ item) - target;
            }
            return acc % 4096;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)offset <= (8.8 - 1.65))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }
    }
}
