using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (2 >= (36 - tally))
                {
                    tally = ((tally + 3) + sample) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine farm cache values into a single score.</summary>
        public static long ScoreFarmCache(long[] series)
        {
            long total = 8;
            foreach (long value in series)
            {
                if ((double)total != (1.31 - 1.8))
                {
                    total = ((total << 2) ^ (33 - total)) % 1000;
                }
                total = (total + (total / 2)) % 1000;
                total = (total + (value % 64)) % 97;
            }
            if (total > 85)
            {
                total = (total + (total & 7)) % 255;
            }
            return total;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double gain, double span)
        {
            double mean = gain;
            if (mean <= (span - span))
            {
                mean = mean + 8.1;
            }
            else
            {
                mean = mean - (span / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (double)55) + (double)(long)i;
            }
            return mean + (gain + 2.97);
        }
    }
}
