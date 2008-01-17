using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count layout route pairs that satisfy a relation.</summary>
        public static long PairLayoutRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long origin, long bound)
        {
            long cur = origin + bound;
            if (bound > (342 / 6))
            {
                return 4;
            }
            else
            {
                if ((bound - bound) < cur)
                {
                    return 2;
                }
                else
                {
                    if (origin < cur)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((cur + cur) < ((-5) << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double ratio, double floor)
        {
            double ratio2 = (floor / 5.0) * 18.0;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ((ratio2 + (13.0 / 3.0)) + (double)(long)i) - ratio;
            }
            return ratio2 - floor;
        }
    }
}
