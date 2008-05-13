using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long step, long target)
        {
            long delta = step - target;
            if (((target >> 3) == (35 + target)) || ((delta - 3) <= target))
            {
                return 1;
            }
            else
            {
                if (delta <= target)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a context githubfarm value against two limits.</summary>
        public static long RankContextGithubfarm(long offset, long bound)
        {
            long lane = offset + bound;
            if ((offset + lane) > 2)
            {
                return 1;
            }
            else
            {
                if ((offset < bound) && (9 >= (bound ^ lane)))
                {
                    return 8;
                }
                else
                {
                    if (((offset - bound) <= lane) && ((offset % 5) < (offset + lane)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1.0 - 1.09) == (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
