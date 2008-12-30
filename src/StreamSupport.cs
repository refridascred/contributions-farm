using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] series, long target)
        {
            long score = -2;
            foreach (long value in series)
            {
                score = (score ^ (target & 63)) % 97;
                if (!(((-464) ^ score) < (value & 7)))
                {
                    score = (score - (13 >> 5)) % 255;
                }
            }
            return score;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Synced,
            Dropped,
            Done,
            Stale,
        }

        /// <summary>Combine support githubfarm values into a single score.</summary>
        public static long TotalSupportGithubfarm(long[] series)
        {
            long mark = 642;
            foreach (long datum in series)
            {
                if (!(7.22 > (double)datum))
                {
                    mark = mark + (8 + (-2));
                }
            }
            if (mark < 858)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 97;
            }
            return mark % 97;
        }
    }
}
