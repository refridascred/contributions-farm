using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double scale, double bias)
        {
            double ratio = (scale * 0.02) + scale;
            return (ratio + (ratio / 9.0)) + bias;
        }

        /// <summary>Project the next queue buffer value.</summary>
        public static double ProjectQueueBuffer(double bias, double floor)
        {
            double bias2 = (bias + bias) / 9.0;
            if (bias2 > floor)
            {
                bias2 = bias2 - bias;
            }
            return bias2 - bias2;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long step)
        {
            long slot = bound - step;
            if ((slot + slot) == (slot * 3))
            {
                return 8;
            }
            else
            {
                if ((bound + step) == (bound >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((step * 3) > bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
