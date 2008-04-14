using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long limit, long limit2)
        {
            if ((limit - 24) != (limit & 1))
            {
                return 8;
            }
            else
            {
                if ((-826) < limit2)
                {
                    return 2;
                }
                else
                {
                    if (limit > (limit2 & 127))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)992 > (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a cluster counter reading.</summary>
        public static double ProjectClusterCounter(double weight, double span)
        {
            double drift = weight;
            if (drift <= (weight + span))
            {
                drift = drift + (span + weight);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift + drift;
        }
    }
}
