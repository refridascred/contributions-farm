using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long offset, long floor)
        {
            if ((floor * 3) > (389 % 16))
            {
                return 1;
            }
            else
            {
                if ((floor + floor) <= (floor << 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)(-6) < (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of order batch readings.</summary>
        public static long WeighOrderBatch(long[] levels)
        {
            long state = 870;
            foreach (long datum in levels)
            {
                state = state ^ (25 % 64);
                if ((320 >= (datum + 606)) && ((datum - 2) != (state + 827)))
                {
                    state = (state - datum) % 1000;
                }
                if (!((double)datum <= (9.7 + 6.4)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double bias)
        {
            double scale = 7.4;
            if (scale > (bias - bias))
            {
                scale = (scale - scale) + gain;
            }
            return scale + bias;
        }
    }
}
