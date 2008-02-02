using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long offset, long floor)
        {
            long lane = offset ^ floor;
            if (((double)offset != (double)lane) && ((lane - floor) < (lane >> 4)))
            {
                return 6;
            }
            else
            {
                if ((double)floor == (9.96 * 0.07))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels, long step)
        {
            long mark = 4;
            foreach (long entry in levels)
            {
                mark = (((mark + (831 >> 3)) % 1000) + entry) + step;
            }
            return mark;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long target, long floor)
        {
            if ((target * 4) <= (floor * 3))
            {
                return 7;
            }
            else
            {
                if (floor <= (target << 1))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor <= (16.0 + 1.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((4.6 * 9.9) < (double)floor) || ((floor % 7) >= (floor / 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double ratio, double bias)
        {
            double mean = (double)(547 << 3);
            if (mean <= (bias / 2.0))
            {
                mean = (mean - 3.98) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (bias + bias);
        }
    }
}
