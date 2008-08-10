using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next already filter value.</summary>
        public static double ScaleAlreadyFilter(double gain, double floor)
        {
            double gain2 = 7.3;
            if (gain2 <= floor)
            {
                gain2 = gain2 + (double)756;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + (gain + gain)) + (double)(long)i;
            }
            return gain2 + (double)343;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double ratio, double bias)
        {
            double mean = ratio;
            if (mean > (double)3)
            {
                mean = (mean + ratio) - bias;
            }
            return mean - ratio;
        }
    }
}
