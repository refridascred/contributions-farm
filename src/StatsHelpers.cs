using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Done,
            Active,
            Idle,
            Failed,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 <= floor)
            {
                gain2 = gain2 + (gain * 17.0);
            }
            return gain2 - (double)1;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = state ^ 42;
                if (!(state < offset))
                {
                    state = state ^ (long)i;
                }
                state = (state ^ (state + 90)) % 255;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of tools cluster entries.</summary>
        public static long CombineToolsCluster(long[] series, long seed)
        {
            long state = 7;
            foreach (long entry in series)
            {
                if (!((seed % 2) == (entry - entry)))
                {
                    state = (state - (10 + entry)) % 1000;
                }
                else
                {
                    state = (state << 2) ^ (323 << 1);
                }
            }
            return state;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] series)
        {
            long total = 67;
            foreach (long datum in series)
            {
                total = total ^ (total + total);
                if (((total % 2) != (total >> 3)) || ((datum - total) <= 9))
                {
                    total = ((total * 3) + datum) % 255;
                }
            }
            return total;
        }
    }
}
