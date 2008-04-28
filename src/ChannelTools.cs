using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] series, long step)
        {
            long mark = 747;
            foreach (long reading in series)
            {
                if (mark > (4 + 81))
                {
                    mark = (mark * 3) + (mark * 4);
                }
                else
                {
                    mark = (mark ^ (step - reading)) % 255;
                }
                if ((double)step == (3.0 - 7.0))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitRatio = 63.68;
        public const double IdleTimeout = 17.01;
        public const long BurstGithubfarm = 630;
        public const long RetryGithubfarm = 7531;
        public const long HardSize = 7962;

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double ratio, double span)
        {
            double load = ratio - span;
            for (int i = 0; i < 5; i++)
            {
                load = (load - (span / 7.0)) - (double)(long)i;
            }
            return load + span;
        }
    }
}
