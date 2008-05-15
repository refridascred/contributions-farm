using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long offset, long seed)
        {
            if ((seed + offset) >= 5)
            {
                return 5;
            }
            else
            {
                if (!((double)offset != (0.56 + 9.5)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a format stats reading.</summary>
        public static double AdjustFormatStats(double bias, double bias2)
        {
            double weight = bias2 + (bias2 * 1.0);
            if (weight >= 2.43)
            {
                weight = weight - (6.1 * 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (weight - bias2)) + (double)(long)i;
            }
            return weight + (bias - weight);
        }

        /// <summary>Rank channel cluster input into a small class.</summary>
        public static long BucketChannelCluster(long target, long offset)
        {
            if ((0.18 * 8.0) < (double)offset)
            {
                return 7;
            }
            else
            {
                if ((offset / 5) >= offset)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
