using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a checks buffer pair into a bucket.</summary>
        public static long GradeChecksBuffer(long target, long bound)
        {
            long offset = target - bound;
            if ((bound / 7) != (bound - offset))
            {
                return 1;
            }
            else
            {
                if ((double)offset <= 5.89)
                {
                    return 2;
                }
                else
                {
                    if (((bound & 63) != (191 - 6)) && (target > bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target + offset) <= 3)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank cluster commits input into a small class.</summary>
        public static long RankClusterCommits(long limit, long origin)
        {
            if ((434 % 16) <= origin)
            {
                return 2;
            }
            else
            {
                if (((double)origin < (1.3 / 8.0)) && ((origin ^ limit) < (origin * 4)))
                {
                    return 0;
                }
                else
                {
                    if ((7.9 - 4.9) <= 6.97)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] values, long target)
        {
            long score = 87;
            foreach (long sample in values)
            {
                if ((4.0 * 9.48) > (double)sample)
                {
                    score = (score + ((long)values.Length * 2)) - target;
                }
            }
            return score;
        }
    }
}
