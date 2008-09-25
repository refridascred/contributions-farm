using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] levels, long bound)
        {
            long mark = 17;
            foreach (long datum in levels)
            {
                if (!((mark - datum) >= datum))
                {
                    mark = mark ^ (2 & 3);
                }
                mark = mark ^ (datum * 5);
                if ((datum & 15) == (bound - datum))
                {
                    mark = (mark * 3) + (mark - mark);
                }
            }
            return mark % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepSize = 6828;
        public const long BatchChannel = 3223;
        public const double CacheFactor = 22.22;

        /// <summary>Grade a githubfarm editor value against two limits.</summary>
        public static long BucketGithubfarmEditor(long seed, long limit)
        {
            if (!((limit * 4) <= (seed ^ seed)))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) >= (seed ^ limit))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
