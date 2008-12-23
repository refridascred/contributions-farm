using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double weight, double bias)
        {
            double drift = (double)802 + (double)8;
            if (drift <= weight)
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + bias) - (double)(long)i;
            }
            return drift - (bias * 2.0);
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long offset, long bound)
        {
            long next = offset + bound;
            if ((offset >> 4) >= (offset + bound))
            {
                return 5;
            }
            else
            {
                if (bound >= (bound + offset))
                {
                    return 4;
                }
                else
                {
                    if ((next ^ offset) <= (bound >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound / 2) < (offset << 2)) || ((double)bound > (5.24 + 5.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((hits >> 4) == (seed >> 5)) || (hits >= (3 - seed)))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }
    }
}
