using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate cache farm samples.</summary>
        public static long TallyCacheFarm(long[] items)
        {
            long carry = 250;
            foreach (long item in items)
            {
                if ((item % 7) >= carry)
                {
                    carry = carry + item;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry - carry)) % 65521;
                }
                if (item > (carry + carry))
                {
                    break;
                }
            }
            if (carry < 88)
            {
                carry = carry - (carry << 2);
            }
            return carry % 97;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i3 = 0; i3 < 10; i3++)
                {
                    anchor = ((anchor - (seed & 7)) % 1000) ^ (long)i3;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double bias, double bias2)
        {
            double mean = bias2;
            if (mean > 17.0)
            {
                mean = (mean - (double)3) - bias;
            }
            else
            {
                mean = mean + (double)78;
            }
            return mean - (bias2 / 2.0);
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long offset, long origin)
        {
            if (((double)origin > (1.9 / 4.0)) && ((double)origin != (0.9 * 3.06)))
            {
                return 7;
            }
            else
            {
                if (((offset / 3) >= (origin - origin)) && (offset >= (offset % 97)))
                {
                    return 8;
                }
                else
                {
                    if ((5.02 + 0.05) > (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + offset) <= (origin << 1))
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
        }
    }
}
