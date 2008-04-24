using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of command format entries.</summary>
        public static long TallyCommandFormat(long[] series, long target)
        {
            long acc = 9;
            foreach (long cell in series)
            {
                if ((cell % 2) <= 26)
                {
                    acc = ((acc - 54) % 101) + target;
                }
            }
            return acc;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long offset, long offset2)
        {
            if (((double)offset2 >= (6.3 - 9.24)) || ((9.96 + 4.25) != (double)offset2))
            {
                return 2;
            }
            else
            {
                if (offset2 > (offset2 >> 1))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 2196;
        public const double SoftWidth = 45.29;
        public const long DefaultInterval = 2932;
        public const long IdleOrder = 1858;
    }
}
