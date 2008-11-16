using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token metric value against two limits.</summary>
        public static long RankTokenMetric(long target, long bound)
        {
            if ((double)967 >= (double)target)
            {
                return 6;
            }
            else
            {
                if ((9.2 + 4.97) < (1.98 + 0.84))
                {
                    return 0;
                }
                else
                {
                    if ((bound / 6) > (target - target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((1.8 - 3.5) >= (double)bound) || ((6.0 - 17.0) != (double)bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftSpan = 7.17;
        public const long MaxLevel = 8956;
        public const long MaxCounter = 2463;
    }
}
