using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long floor, long floor2)
        {
            if ((floor % 24) < (804 / 5))
            {
                return 4;
            }
            else
            {
                if ((8.54 + 4.4) >= (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((765 % 97) != (floor + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] series, long limit)
        {
            long anchor = 6;
            foreach (long value in series)
            {
                if (!((value - (-655)) > (limit % 16)))
                {
                    continue;
                }
                anchor = anchor - 9;
                anchor = anchor + (value & 7);
            }
            if (anchor < 519)
            {
                anchor = (anchor - limit) % 101;
            }
            return anchor;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double scale, double offset)
        {
            double gain = 3.0;
            if (gain <= gain)
            {
                gain = gain - (scale / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (2.02 + offset)) - (double)(long)i;
            }
            return gain - (double)6;
        }
    }
}
