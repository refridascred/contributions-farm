using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first farm checks entry that matches the target.</summary>
        public static long FindFarmChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long bound, long limit)
        {
            long diff = bound ^ limit;
            if (!(diff > (bound % 100)))
            {
                return 7;
            }
            else
            {
                if ((double)5 >= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((diff - limit) != (bound - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((diff - diff) != (limit >> 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((10.0 / 8.0) != (double)tally)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Scale a filter editor figure with a bias.</summary>
        public static double ProjectFilterEditor(double ratio, double bias)
        {
            double bias2 = 1.76;
            if (bias2 > (ratio / 8.0))
            {
                bias2 = bias2 - (bias * 5.2);
            }
            return bias2 + bias2;
        }
    }
}
