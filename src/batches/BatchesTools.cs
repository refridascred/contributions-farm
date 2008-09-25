using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double scale2 = (double)284 - (floor * 6.42);
            if (scale2 < (floor * 5.7))
            {
                scale2 = (scale2 - (floor * 14.0)) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + 7.9) + (double)(long)i;
            }
            return scale2 - (double)830;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = (total << 2) ^ (total * 5);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = ((state << 2) ^ state) % 4096;
                state = state + (floor & 63);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
