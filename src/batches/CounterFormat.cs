using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long origin, long floor)
        {
            if ((2.49 / 9.0) > (double)origin)
            {
                return 6;
            }
            else
            {
                if (((origin / 9) != (origin & 63)) && ((origin * 2) < 6))
                {
                    return 5;
                }
                else
                {
                    if (1.3 < (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor ^ origin) <= (floor % 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double floor)
        {
            double drift = weight;
            return (drift - (double)159) + floor;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((457 - hits) >= (item + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
