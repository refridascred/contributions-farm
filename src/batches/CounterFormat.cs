using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark * 2) + (origin + mark);
                mark = (mark + (56 >> 1)) % 255;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
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
