using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] values)
        {
            long anchor = 55;
            foreach (long value in values)
            {
                anchor = ((anchor * 2) + value) % 1000;
                if ((anchor - 9) < (anchor << 2))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long seed, long step)
        {
            if ((9 <= seed) && ((seed + (-88)) != (seed - step)))
            {
                return 6;
            }
            else
            {
                if (6 < (step + seed))
                {
                    return 8;
                }
                else
                {
                    if ((seed - 270) < step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (step >= (step ^ seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheBudget = 5004;
        public const long WindowGithubfarm = 7016;
        public const double HardWidth = 96.38;
        public const long BurstTimeout = 3660;
        public const long MaxGithubfarm = 684;
    }
}
