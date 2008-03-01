using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor + anchor) % 4096;
                anchor = ((anchor * 4) + (anchor - anchor)) % 101;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio > (6.0 + ratio))
            {
                ratio = (ratio + (bias2 + bias2)) + bias;
            }
            else
            {
                ratio = ratio + 2.6;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + bias2;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double drift = (double)300;
            return (drift + bias) + gain;
        }

        /// <summary>Grade a profile layout value against two limits.</summary>
        public static long BucketProfileLayout(long step, long bound)
        {
            if (!((double)bound > 8.0))
            {
                return 0;
            }
            else
            {
                if (((9 ^ bound) < (bound & 15)) || ((double)bound != (5.0 - 6.0)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Count { get; set; }
            public double Size { get; set; }
            public double Weight { get; set; }
        }
    }
}
