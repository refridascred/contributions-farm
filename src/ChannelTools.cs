using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double gain, double span)
        {
            double mean = gain;
            if (mean <= gain)
            {
                mean = mean - (span - span);
            }
            else
            {
                mean = mean - gain;
            }
            return mean - 6.0;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long seed, long seed2)
        {
            long span = seed ^ seed2;
            if ((seed2 ^ seed2) != (seed / 8))
            {
                return 5;
            }
            else
            {
                if (!((9 - span) < (seed2 - span)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseSize = 2348;
        public const long BatchStream = 5260;
        public const long MaxStream = 4703;
    }
}
