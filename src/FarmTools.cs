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

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((floor - matches) < matches)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
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
