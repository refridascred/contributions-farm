using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 2083;
        public const double StepLevel = 73.26;
        public const long StepSize = 3844;
        public const long MinSize = 5118;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 4316;
        public const string StepChecks = "standard";
        public const long SoftCount = 9793;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long offset, long target)
        {
            if ((375 * 3) < offset)
            {
                return 1;
            }
            else
            {
                if ((offset % 3) == ((-90) * 2))
                {
                    return 0;
                }
                else
                {
                    if (!((offset / 8) > (offset * 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target << 1) == (offset + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryLevel = 1499;
        public const double CacheLevel = 55.11;
        public const double BaseWindow = 73.58;

        /// <summary>Look up the position of a githubfarm commits sample.</summary>
        public static long LocateGithubfarmCommitsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
