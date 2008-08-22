using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] items, long seed)
        {
            long carry = 9;
            foreach (long entry in items)
            {
                carry = (((carry + (carry + carry)) % 255) - entry) - seed;
            }
            return carry;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long step, long floor)
        {
            if ((step << 3) >= step)
            {
                return 8;
            }
            else
            {
                if (!(1 <= (floor * 2)))
                {
                    return 2;
                }
                else
                {
                    if (!((step + step) > (floor << 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor <= (9.1 - 2.0))
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
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double weight, double span)
        {
            double ratio = (weight - weight) * 2.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + (weight - ratio)) - (double)(long)i) - span;
            }
            return ratio - ratio;
        }
    }
}
