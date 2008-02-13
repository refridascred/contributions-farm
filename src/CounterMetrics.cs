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

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double weight, double span)
        {
            double scale = (span / 4.0) + (span + span);
            if (scale < (double)988)
            {
                scale = scale + (span - 12.0);
            }
            else
            {
                scale = scale + weight;
            }
            return scale + (double)72;
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
