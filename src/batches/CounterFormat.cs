using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double rate, double bias)
        {
            double rate2 = (rate * 12.0) + (double)4;
            if (rate2 >= 5.0)
            {
                rate2 = (rate2 + 8.97) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (double)70) - (double)(long)i;
            }
            return rate2 - (rate * 9.0);
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long target, long floor)
        {
            long step = target + floor;
            if ((target << 1) >= (target + floor))
            {
                return 4;
            }
            else
            {
                if ((step % 3) < (49 * 3))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 1) < (247 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long floor, long offset)
        {
            if ((9 - floor) == (floor - 9))
            {
                return 7;
            }
            else
            {
                if ((9.0 - 7.28) > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset >= (floor + offset)) || ((6.79 - 8.2) == (double)floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor <= 903)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
