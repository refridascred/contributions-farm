using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long floor, long origin)
        {
            if ((double)origin <= (0.03 - 6.0))
            {
                return 5;
            }
            else
            {
                if ((floor >> 1) >= (74 + floor))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > (2.59 + 20.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two session commits measurements.</summary>
        public static double BlendSessionCommits(double weight, double offset)
        {
            double bias = (double)(8 - (-574));
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias - weight) - (double)(long)i) + offset;
            }
            return bias + weight;
        }

        /// <summary>Compare every pair of format session readings.</summary>
        public static long OverlapFormatSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
