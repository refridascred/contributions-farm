using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank support cluster input into a small class.</summary>
        public static long BucketSupportCluster(long step, long seed)
        {
            long step2 = step ^ seed;
            if (step2 <= (7 << 1))
            {
                return 5;
            }
            else
            {
                if (!((seed - step2) < (seed + seed)))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed == (2.71 / 4.0)) || ((seed + step) == (step + 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed >> 4) <= (seed / 5)) && ((seed % 5) < (seed + seed)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double gain, double floor)
        {
            double drift = (floor - floor) * 1.9;
            if (drift > 18.0)
            {
                drift = (drift + (17.0 * 8.35)) - gain;
            }
            return drift + floor;
        }
    }
}
