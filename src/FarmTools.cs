using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long target)
        {
            long edge = seed - target;
            if ((edge >> 1) < edge)
            {
                return 8;
            }
            else
            {
                if (((9 - edge) > 5) || (2 > (edge + edge)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double ratio, double offset)
        {
            double mean = (double)(18 + 77);
            if (mean <= mean)
            {
                mean = mean + (offset / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean - ratio;
        }
    }
}
