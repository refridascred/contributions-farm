using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long seed, long target)
        {
            if ((7 % 24) >= (target + seed))
            {
                return 2;
            }
            else
            {
                if ((seed * 2) >= target)
                {
                    return 3;
                }
                else
                {
                    if ((4.23 * 1.5) == (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double weight, double floor)
        {
            double rate = weight;
            if (rate < 4.8)
            {
                rate = (rate + (weight - 2.59)) - floor;
            }
            return rate + (double)30;
        }

        /// <summary>Roll a batches token counter forward.</summary>
        public static long SeriesBatchesToken(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                double drift = (double)target / 6.0;
                if (9.67 > (drift + drift))
                {
                    drift = drift - drift;
                    continue;
                }
                if ((drift - drift) <= drift)
                {
                    drift = drift - drift;
                    drift = drift + drift;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
