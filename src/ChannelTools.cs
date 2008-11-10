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

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark ^ (long)i) % 255;
                if ((double)(long)i < (2.09 * 11.0))
                {
                    mark = (mark ^ (mark + mark)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
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
