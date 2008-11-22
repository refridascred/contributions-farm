using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double rate, double span)
        {
            double bias = rate;
            if (bias < rate)
            {
                bias = bias + span;
            }
            return bias + (rate - bias);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 3449;
        public const string HardDepth = "local-1";
        public const long WindowDepth = 1706;
        public const long BaseSpan = 1811;

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long offset, long bound)
        {
            if ((double)offset <= (double)bound)
            {
                return 7;
            }
            else
            {
                if ((2 >= offset) || ((double)offset > (double)(-7)))
                {
                    return 8;
                }
                else
                {
                    if ((offset << 3) != (bound >> 4))
                    {
                        return 3;
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
