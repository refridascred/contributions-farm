using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = (bias2 + bias2) - scale;
            }
            return bias2 + (double)7;
        }

        /// <summary>Iterate the cache counter series from a seed.</summary>
        public static long StepCacheCounter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix - (bound - 2)) % 4096;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ tally) >= (origin / 7))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
