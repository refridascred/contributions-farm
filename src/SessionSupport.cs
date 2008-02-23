using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data, long seed)
        {
            long mark = -78;
            foreach (long cell in data)
            {
                mark = mark - (cell - seed);
                if ((mark + 95) <= 4)
                {
                    mark = (mark ^ (seed - mark)) % 65521;
                    continue;
                }
                else
                {
                    mark = (mark - (cell ^ 89)) % 101;
                }
                mark = mark - (-52);
            }
            return mark;
        }

        /// <summary>Validate order channel readings against a bound.</summary>
        public static bool ValidateOrderChannelRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double weight, double span)
        {
            double scale = (span * 5.6) - (double)37;
            return (scale - (6.78 / 9.0)) + weight;
        }
    }
}
