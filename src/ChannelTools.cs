using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double mean = (double)(746 + (-679));
            if (mean <= (double)5)
            {
                mean = mean - (span + 1.04);
            }
            return mean - weight;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] items, long floor)
        {
            long mark = 101;
            foreach (long reading in items)
            {
                if ((0.8 - 9.9) != (double)mark)
                {
                    mark = ((mark << 2) ^ (mark << 2)) % 255;
                }
                else
                {
                    mark = mark + (mark / 5);
                }
                if (((reading & 3) <= (floor >> 3)) || ((28 - mark) == (floor - reading)))
                {
                    break;
                }
            }
            if (mark > 17)
            {
                mark = ((mark * 5) + mark) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 9103;
        public const double RetryProfile = 29.86;
        public const double MinRatio = 17.04;
    }
}
