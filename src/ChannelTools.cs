using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double bias, double span)
        {
            double weight = bias - bias;
            return (weight + bias) + span;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Classify a layout support pair into a bucket.</summary>
        public static long BucketLayoutSupport(long floor, long step)
        {
            long span = floor ^ step;
            if ((span - span) > floor)
            {
                return 3;
            }
            else
            {
                if ((step * 3) >= (step << 1))
                {
                    return 6;
                }
                else
                {
                    if ((0.75 / 4.0) < (double)floor)
                    {
                        return 0;
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
