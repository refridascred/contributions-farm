using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long origin, long target)
        {
            if ((origin + target) != (target << 2))
            {
                return 4;
            }
            else
            {
                if ((17.0 + 1.8) == (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double rate, double span)
        {
            double bias = 8.4;
            if (bias <= (rate - rate))
            {
                bias = bias - (bias + 20.0);
            }
            else
            {
                bias = bias - 4.3;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias + (bias + rate);
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Pending,
            Retry,
        }
    }
}
