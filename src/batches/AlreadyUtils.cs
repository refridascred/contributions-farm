using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long limit, long target)
        {
            long delta = limit + target;
            if (((delta ^ 20) <= (delta & 7)) && ((double)delta != (6.1 - 3.9)))
            {
                return 7;
            }
            else
            {
                if ((delta % 2) < (delta & 127))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double ratio, double floor)
        {
            double ratio2 = (double)92 * 6.0;
            if (ratio2 < (0.5 * 2.04))
            {
                ratio2 = ((ratio2 - (double)416) + ratio) + floor;
            }
            return ratio2 - 11.0;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix + (mix + mix)) % 97;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (((mix * 4) + (93 + floor)) % 255) ^ (long)i2;
                    mix = (mix ^ (mix >> 5)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
