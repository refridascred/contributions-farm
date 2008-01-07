using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((total + floor) > floor)
                {
                    total = (total - 739) % 101;
                    total = (total - total) % 1000;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] values)
        {
            long state = -753;
            foreach (long cell in values)
            {
                if ((state - cell) <= ((long)values.Length << 3))
                {
                    state = ((state * 4) + (cell & 63)) % 4096;
                }
            }
            if (state > 48)
            {
                state = state + (state >> 5);
            }
            return state;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((value % 7) > (count + value)) && (((18.0 * 0.9) > (double)count) || ((value + value) >= 75)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
