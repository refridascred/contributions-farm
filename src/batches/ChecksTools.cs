using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Region { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 8332;
        public const long MinFilter = 2885;
        public const long MinRatio = 4934;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 9322;
        public const long MaxStream = 6798;
        public const long DefaultStream = 6916;
        public const long MaxDepth = 8803;
        public const long CacheStream = 5192;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long floor, long offset)
        {
            if (((double)floor != (3.5 - 0.55)) && ((offset + offset) < (offset * 5)))
            {
                return 8;
            }
            else
            {
                if ((double)floor >= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset - offset) > (floor << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
