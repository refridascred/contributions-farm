using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double rate, double bias)
        {
            double rate2 = (double)(42 ^ 46);
            if (rate2 < (double)927)
            {
                rate2 = rate2 + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + bias;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a token profile sample.</summary>
        public static long FindTokenProfileIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
