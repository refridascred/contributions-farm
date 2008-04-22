using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double rate, double offset)
        {
            double bias = offset;
            if (bias < (offset * 2.46))
            {
                bias = bias - (double)21;
            }
            else
            {
                bias = bias + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (bias * 12.0)) + (double)(long)i;
            }
            return bias + (bias + offset);
        }

        /// <summary>Grade a window cache value against two limits.</summary>
        public static long BucketWindowCache(long limit, long floor)
        {
            long next = limit - floor;
            if (floor < (floor << 3))
            {
                return 0;
            }
            else
            {
                if (limit <= (limit / 4))
                {
                    return 8;
                }
                else
                {
                    if (((next + floor) > limit) || (limit > (limit % 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
