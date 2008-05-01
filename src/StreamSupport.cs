using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a profile counter reading by value.</summary>
        public static long SeekProfileCounterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double bias, double span)
        {
            double weight = 19.0 + (17.0 * 8.92);
            if (weight < (span + bias))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - 1.0;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (7.5 / 5.0)) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long offset, long floor)
        {
            if ((double)floor <= 7.4)
            {
                return 0;
            }
            else
            {
                if (((offset ^ floor) >= (floor << 1)) || ((double)offset >= 7.0))
                {
                    return 7;
                }
                else
                {
                    if ((floor & 7) <= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((997 + offset) == (floor + offset))
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
        }
    }
}
