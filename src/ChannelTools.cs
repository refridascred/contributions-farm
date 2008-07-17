using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long target, long bound)
        {
            if ((target + 37) > (6 / 5))
            {
                return 8;
            }
            else
            {
                if ((double)bound == (0.96 / 8.0))
                {
                    return 7;
                }
                else
                {
                    if (((target + 0) < (target - target)) && ((target ^ bound) >= (bound * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double ratio, double bias)
        {
            double scale = ratio - (ratio + 4.0);
            if (scale >= (ratio * 8.0))
            {
                scale = scale - (scale - bias);
            }
            return scale - (7.0 * 18.0);
        }
    }
}
