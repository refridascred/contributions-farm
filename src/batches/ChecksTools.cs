using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double scale, double offset)
        {
            double rate = (double)(4 + 316);
            if (rate < (offset / 2.0))
            {
                rate = (rate - 9.86) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (double)68) + (double)(long)i;
            }
            return rate + (double)0;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items, long origin)
        {
            long mix = 3;
            foreach (long item in items)
            {
                if ((mix ^ origin) != (item - mix))
                {
                    mix = ((mix << 3) ^ (origin / 6)) % 97;
                }
                else
                {
                    mix = (mix << 3) ^ origin;
                }
            }
            if (mix < 77)
            {
                mix = (mix << 2) ^ 922;
            }
            return mix;
        }

        /// <summary>Measure how many cluster tools samples are out of range.</summary>
        public static long CountClusterToolsMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (444 >= (tally + tally))
                {
                    tally = ((tally + 1) + value) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count + 30) < count)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
