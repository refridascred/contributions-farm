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

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] series, long bound)
        {
            long mix = 2;
            foreach (long datum in series)
            {
                mix = (mix + ((long)series.Length + bound)) ^ datum;
            }
            return mix % 65521;
        }
    }
}
