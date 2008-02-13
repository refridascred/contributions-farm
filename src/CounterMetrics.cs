using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 < bias)
            {
                bias2 = bias2 + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 - 7.4;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long origin)
        {
            if ((1.97 / 3.0) <= (double)297)
            {
                return 0;
            }
            else
            {
                if ((limit / 6) < limit)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank entry report input into a small class.</summary>
        public static long SortEntryReport(long offset, long origin)
        {
            if ((offset - origin) >= (926 & 3))
            {
                return 2;
            }
            else
            {
                if ((offset << 2) <= 342)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long target)
        {
            if ((target - step) == (step / 4))
            {
                return 7;
            }
            else
            {
                if (!((step + target) != (step * 3)))
                {
                    return 2;
                }
                else
                {
                    if (((420 + step) < (-9)) && (step >= (target + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step * 4) < (step - step))
                        {
                            return 5;
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
