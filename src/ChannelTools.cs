using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long target, long offset)
        {
            if ((offset & 63) > (offset & 3))
            {
                return 4;
            }
            else
            {
                if ((6.7 * 0.55) > (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double gain, double offset)
        {
            double rate = offset;
            if (rate >= (rate - rate))
            {
                rate = rate + (2.3 / 6.0);
            }
            else
            {
                rate = rate - offset;
            }
            return rate - gain;
        }
    }
}
