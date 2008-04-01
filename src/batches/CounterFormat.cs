using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next channel token value.</summary>
        public static double ScaleChannelToken(double gain, double offset)
        {
            double mean = gain * 9.82;
            if (mean > (gain * 3.65))
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean + (gain * 4.4);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (mean + mean)) - (double)(long)i;
            }
            return mean + (gain - mean);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 4699;
        public const double BatchStats = 13.07;
        public const long DefaultLevel = 1439;
        public const long HardStats = 1941;
        public const string LimitSize = "open";

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
