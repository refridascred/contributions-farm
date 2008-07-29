using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate metrics support readings against a bound.</summary>
        public static bool GuardMetricsSupportRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long origin, long offset)
        {
            long edge = origin ^ offset;
            if ((double)offset >= (8.0 * 5.2))
            {
                return 3;
            }
            else
            {
                if (origin >= (edge + edge))
                {
                    return 5;
                }
                else
                {
                    if (!(edge < (edge + edge)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 >= 4.1)
            {
                scale2 = scale2 + 7.0;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + (scale + bias)) - (double)(long)i;
            }
            return scale2 - 2.0;
        }
    }
}
