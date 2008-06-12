using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long target, long target2)
        {
            if (target2 >= (target2 ^ target))
            {
                return 3;
            }
            else
            {
                if ((target + target2) != (target - 2))
                {
                    return 8;
                }
                else
                {
                    if (((target ^ target) != (target2 & 255)) && ((8 * 3) < (target % 97)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target2 < (target % 7)) || ((target2 * 3) < target2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long seed, long bound)
        {
            if (seed <= (bound + bound))
            {
                return 7;
            }
            else
            {
                if (((2.4 + 3.43) < (double)bound) && ((double)bound < (double)6))
                {
                    return 6;
                }
                else
                {
                    if (((bound + bound) == (seed ^ bound)) && (bound >= (bound << 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
