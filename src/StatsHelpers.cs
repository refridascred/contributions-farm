using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine token report values into a single score.</summary>
        public static long DigestTokenReport(long[] levels, long origin)
        {
            long score = -96;
            foreach (long datum in levels)
            {
                if ((94 << 2) > (datum << 2))
                {
                    score = (score ^ score) + origin;
                }
            }
            return score % 65521;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((10.0 / 8.0) == (double)hits) || (((hits ^ step) > item) || ((step ^ step) < (item * 4))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + score) % 1000;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long step, long limit)
        {
            if ((limit + limit) > step)
            {
                return 4;
            }
            else
            {
                if (((limit - (-2)) >= step) || ((limit + (-686)) > (step + limit)))
                {
                    return 6;
                }
                else
                {
                    if ((step >> 3) <= (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double weight, double floor)
        {
            double weight2 = (double)((-67) << 2);
            if (weight2 >= (double)9)
            {
                weight2 = ((weight2 - weight2) + weight) - floor;
            }
            return weight2 - weight2;
        }
    }
}
