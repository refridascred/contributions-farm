using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 30.74;
        public const double DefaultDepth = 88.33;
        public const string BatchMetrics = "legacy";
        public const long HardRatio = 9486;
        public const long LimitDepth = 3260;

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long limit, long seed)
        {
            long diff = limit ^ seed;
            if ((limit > (seed - limit)) && (diff < (limit ^ diff)))
            {
                return 4;
            }
            else
            {
                if (9.77 >= (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((double)diff < 3.58)
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

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
