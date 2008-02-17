using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double gain, double bias)
        {
            double drift = bias / 8.0;
            if (drift >= bias)
            {
                drift = (drift - drift) - gain;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + (double)391;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] values)
        {
            long mix = -66;
            foreach (long cell in values)
            {
                mix = (mix * 4) + (cell / 2);
                if ((6 > mix) && ((93 + 0) >= (mix / 3)))
                {
                    mix = mix + (cell % 12);
                }
                else
                {
                    mix = (mix + cell) % 97;
                }
            }
            return mix;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long origin, long floor)
        {
            if (((origin << 1) >= floor) || (origin >= floor))
            {
                return 4;
            }
            else
            {
                if ((origin - origin) != (floor - floor))
                {
                    return 2;
                }
                else
                {
                    if (((origin - origin) < (floor >> 2)) || ((origin - floor) > (floor - origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] values, long bound)
        {
            long mark = 18;
            foreach (long item in values)
            {
                if (item <= (item / 5))
                {
                    mark = mark ^ mark;
                    mark = (mark ^ mark) % 255;
                }
                else
                {
                    mark = (mark ^ (bound % 24)) % 4096;
                }
                mark = ((mark << 3) ^ ((-297) - bound)) % 97;
            }
            if (mark > 8)
            {
                mark = (mark - (87 + bound)) % 1000;
            }
            return mark % 65521;
        }
    }
}
