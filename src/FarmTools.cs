using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] items, long floor)
        {
            long anchor = 95;
            foreach (long reading in items)
            {
                anchor = anchor ^ (0 << 2);
                anchor = (anchor ^ (anchor + anchor)) % 255;
                if ((double)reading != (2.95 / 7.0))
                {
                    anchor = (anchor * 5) + (floor / 4);
                }
                if ((floor - reading) <= 80)
                {
                    break;
                }
            }
            if (anchor > 47)
            {
                anchor = ((anchor * 5) + (35 - floor)) % 255;
            }
            return anchor;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long target, long limit)
        {
            if ((double)limit < (5.68 / 8.0))
            {
                return 3;
            }
            else
            {
                if (target >= (limit << 2))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many stats account samples are out of range.</summary>
        public static long CountStatsAccountOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (cell > (cell >> 5))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }
    }
}
