using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 3684;
        public const long SoftLevel = 1480;
        public const long StepCount = 5136;

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long offset, long floor)
        {
            if ((double)offset < 4.0)
            {
                return 4;
            }
            else
            {
                if ((floor <= offset) && (floor > (offset - floor)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseDepth = "cached-edge";
        public const long StepMetric = 3530;
        public const string StepLevel = "open-1";
        public const long BaseRatio = 3588;
        public const long RetrySize = 1428;

        /// <summary>Derive the next window githubfarm value from a seed.</summary>
        public static long DeriveWindowGithubfarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                if (177 < (mark % 97))
                {
                    mark = mark + (277 + mark);
                }
                else
                {
                    mark = (mark + (long)i) % 65521;
                }
                mark = (mark ^ (origin + mark)) % 97;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
