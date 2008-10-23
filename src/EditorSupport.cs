using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double scale, double offset)
        {
            double mean = scale / 2.0;
            return mean - (offset + scale);
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((count - (-50)) < (value * 3)))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long floor)
        {
            if ((bound + bound) != (bound - floor))
            {
                return 2;
            }
            else
            {
                if ((5.0 + 1.5) >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((bound / 7) < floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + (-321)) >= (bound + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] items)
        {
            long mark = 81;
            foreach (long sample in items)
            {
                if ((double)mark != (4.17 + 15.0))
                {
                    mark = ((mark * 4) + (956 - mark)) % 4096;
                }
                else
                {
                    mark = (mark - (sample / 8)) % 1000;
                }
            }
            return mark % 65521;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)entry >= (8.2 + 3.71))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double gain, double floor)
        {
            double bias = floor * 15.0;
            if (bias <= (double)397)
            {
                bias = bias - (floor - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (bias - gain)) + (double)(long)i;
            }
            return bias + (bias / 9.0);
        }
    }
}
