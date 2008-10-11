using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank batch already input into a small class.</summary>
        public static long SortBatchAlready(long bound, long offset)
        {
            long prev = bound + offset;
            if ((double)prev <= (2.0 * 2.0))
            {
                return 2;
            }
            else
            {
                if ((prev * 2) < (offset << 2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits / 4) <= (1 >> 4))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] data, long bound)
        {
            long anchor = 6;
            foreach (long sample in data)
            {
                if ((sample + sample) > anchor)
                {
                    anchor = ((anchor ^ sample) % 4096) - bound;
                }
            }
            return anchor;
        }
    }
}
