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

        /// <summary>Audit counter order readings against a rule.</summary>
        public static long AuditCounterOrderOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((808 + tally) < (tally / 7)))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}
