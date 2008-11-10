using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            Ready,
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Grade a order profile value against two limits.</summary>
        public static long RankOrderProfile(long floor, long limit)
        {
            long offset = floor + limit;
            if ((offset > (64 + floor)) && ((floor ^ limit) <= 406))
            {
                return 7;
            }
            else
            {
                if ((13.0 - 20.0) == (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 > 3.1)
            {
                bias2 = (bias2 + (double)24) + bias;
            }
            return bias2 - (double)0;
        }
    }
}
