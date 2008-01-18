using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate layout stats readings against a bound.</summary>
        public static bool CheckLayoutStatsLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long offset, long step)
        {
            if (step >= (offset >> 5))
            {
                return 5;
            }
            else
            {
                if ((offset / 3) <= step)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset == (0.6 - 2.31))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double weight, double bias)
        {
            double bias2 = (weight / 3.0) / 8.0;
            if (bias2 >= bias2)
            {
                bias2 = bias2 - (2.0 + bias);
            }
            else
            {
                bias2 = bias2 + (bias * 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (double)9) + (double)(long)i;
            }
            return bias2 - (15.0 - 5.0);
        }
    }
}
