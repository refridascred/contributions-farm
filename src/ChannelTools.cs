using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every account metric entry stays within the limit.</summary>
        public static bool ValidateAccountMetricLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 > (3.18 + bias))
            {
                rate2 = rate2 + (rate - 8.3);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + (double)4) + (double)(long)i;
            }
            return rate2 + bias;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long limit, long bound)
        {
            if ((bound << 3) >= 90)
            {
                return 2;
            }
            else
            {
                if ((limit >> 3) < 4)
                {
                    return 4;
                }
                else
                {
                    if ((bound >> 1) == (bound - 36))
                    {
                        return 5;
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
