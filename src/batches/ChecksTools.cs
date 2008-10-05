using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double scale, double bias)
        {
            double scale2 = scale;
            for (int i = 0; i < 2; i++)
            {
                scale2 = ((scale2 + (scale + 4.46)) + (double)(long)i) - bias;
            }
            return scale2 + (double)41;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a layout stream pair into a bucket.</summary>
        public static long BucketLayoutStream(long offset, long floor)
        {
            if (((double)floor > (11.0 / 6.0)) || ((10.0 + 11.0) > (8.7 - 7.2)))
            {
                return 5;
            }
            else
            {
                if ((4.2 + 5.0) > 0.3)
                {
                    return 8;
                }
                else
                {
                    if ((offset <= ((-79) - 110)) || ((double)floor >= (15.0 / 5.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long offset, long origin)
        {
            if ((offset + origin) >= (offset + offset))
            {
                return 2;
            }
            else
            {
                if (((1.0 / 7.0) >= (double)offset) && ((2.0 - 3.34) > (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
