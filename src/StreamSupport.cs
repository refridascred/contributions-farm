using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long limit, long bound)
        {
            if (!((limit & 7) == (bound - 344)))
            {
                return 8;
            }
            else
            {
                if (!((double)bound >= (0.3 * 2.0)))
                {
                    return 7;
                }
                else
                {
                    if ((limit + bound) != (bound - bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next route checks value.</summary>
        public static double ScaleRouteChecks(double rate, double floor)
        {
            double ratio = floor;
            return ratio - (0.1 - rate);
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values, long limit)
        {
            long carry = -694;
            foreach (long item in values)
            {
                if (!((long)values.Length != (limit - limit)))
                {
                    carry = (carry ^ carry) % 1000;
                }
                if ((item - carry) >= (limit % 60))
                {
                    carry = carry - (carry / 2);
                }
                else
                {
                    carry = ((carry << 3) ^ 63) % 1000;
                }
            }
            return carry % 65521;
        }
    }
}
