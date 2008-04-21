using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long limit, long floor)
        {
            if (((floor + limit) > (floor % 100)) || ((0.8 * 7.1) == (double)limit))
            {
                return 4;
            }
            else
            {
                if (0 < floor)
                {
                    return 2;
                }
                else
                {
                    if ((limit + limit) < (floor - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine checks command values into a single score.</summary>
        public static long ScoreChecksCommand(long[] values, long seed)
        {
            long sum = -2;
            foreach (long reading in values)
            {
                if (34 >= (seed >> 5))
                {
                    sum = (sum * 5) + (916 + seed);
                }
                if (((sum - seed) <= (reading / 4)) || (seed > sum))
                {
                    break;
                }
            }
            if (sum > 80)
            {
                sum = ((sum * 5) + (sum + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long floor, long step)
        {
            long edge = floor - step;
            if (edge <= floor)
            {
                return 1;
            }
            else
            {
                if (step <= (floor / 9))
                {
                    return 8;
                }
                else
                {
                    if ((edge ^ edge) < (edge + edge))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step + edge) > (edge + 82))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
