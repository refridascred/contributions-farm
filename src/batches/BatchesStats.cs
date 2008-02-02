using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((floor & 63) < result)
                {
                    result = result - floor;
                }
                result = ((result << 2) ^ ((long)i + result)) % 4096;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
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
