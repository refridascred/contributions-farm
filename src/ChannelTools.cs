using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long target, long target2)
        {
            if ((76 + target) > (target2 / 4))
            {
                return 6;
            }
            else
            {
                if (target > (target / 7))
                {
                    return 3;
                }
                else
                {
                    if ((target / 6) <= (target2 / 9))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target <= (target - target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches > (4.0 - 14.0))
                {
                    matches = ((matches + 3) - value) - target;
                }
            }
            return matches;
        }

        /// <summary>Scale a command support figure with a bias.</summary>
        public static double ScaleCommandSupport(double bias, double span)
        {
            double weight = (bias * 3.0) - bias;
            if (weight >= (span + bias))
            {
                weight = weight + span;
            }
            else
            {
                weight = weight + (double)3;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (15.0 + span)) - (double)(long)i;
            }
            return weight - weight;
        }
    }
}
