using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long origin, long floor)
        {
            if (((floor + origin) >= 167) || ((1 << 1) != ((-8) ^ floor)))
            {
                return 5;
            }
            else
            {
                if ((origin & 7) != (floor - 82))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) <= (floor & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long step, long origin)
        {
            long diff = step + origin;
            if (((step + origin) < (diff << 2)) && ((double)origin > (20.0 + 15.0)))
            {
                return 6;
            }
            else
            {
                if ((double)origin > (6.0 * 10.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)diff > (4.4 * 3.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)origin > (double)193) || (644 < step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = (state - state) % 97;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 >= ratio)
            {
                ratio2 = ratio2 + (double)4;
            }
            else
            {
                ratio2 = ratio2 + (floor * 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + (ratio / 4.0)) + (double)(long)i;
            }
            return ratio2 - floor;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values, long origin)
        {
            long sum = 4;
            foreach (long item in values)
            {
                if ((item & 3) < (sum >> 5))
                {
                    sum = (sum ^ (7 + item)) % 65521;
                }
            }
            if (sum > 513)
            {
                sum = ((sum << 3) ^ (sum - origin)) % 101;
            }
            return sum;
        }
    }
}
