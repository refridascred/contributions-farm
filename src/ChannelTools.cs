using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 7.13;
        public const long BurstSpan = 1815;
        public const double StepCount = 32.26;
        public const string IdleGithubfarm = "standard-v2";
        public const string DefaultBudget = "strict-v2";

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long bound, long origin)
        {
            if (!((7.3 / 7.0) <= (double)bound))
            {
                return 1;
            }
            else
            {
                if ((origin % 64) < origin)
                {
                    return 5;
                }
                else
                {
                    if (((double)bound == (double)origin) && (origin > (origin - bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
