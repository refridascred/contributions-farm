using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 > (double)92)
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 + (double)30;
            }
            return bias2 + offset;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 7224;
        public const string IdleGraph = "legacy-v2";
        public const long BurstFactor = 151;
        public const double MaxGraph = 60.87;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long bound, long seed)
        {
            long lane = bound ^ seed;
            if ((double)seed > (1.0 * 13.0))
            {
                return 2;
            }
            else
            {
                if ((double)seed > (5.0 / 9.0))
                {
                    return 8;
                }
                else
                {
                    if (((double)lane <= (double)5) && ((seed * 3) <= (seed & 15)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
