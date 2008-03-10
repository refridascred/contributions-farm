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

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
