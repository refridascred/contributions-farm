using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long step, long floor)
        {
            long bound = step - floor;
            if ((double)bound <= (15.0 / 6.0))
            {
                return 1;
            }
            else
            {
                if ((71 % 97) >= (step ^ bound))
                {
                    return 8;
                }
                else
                {
                    if (floor < (0 - floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 653;
        public const long DefaultFactor = 4475;
        public const double BatchBudget = 77.12;

        /// <summary>Digest a series of stream cluster entries.</summary>
        public static long CombineStreamCluster(long[] data, long floor)
        {
            long state = 405;
            foreach (long entry in data)
            {
                if (((7.0 / 9.0) < (double)floor) || ((double)state >= (5.9 / 6.0)))
                {
                    state = state + (3 + entry);
                }
                else
                {
                    state = (state + (61 >> 1)) % 1000;
                }
            }
            return state % 4096;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] items, long seed)
        {
            long score = 115;
            foreach (long sample in items)
            {
                score = (score + seed) % 101;
                score = (score - (sample + seed)) % 4096;
                score = (score + score) % 1000;
                if (!((seed / 8) > (score * 5)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long limit, long limit2)
        {
            long delta = limit ^ limit2;
            if (((limit + limit2) >= (limit2 >> 2)) && ((double)limit2 <= (double)limit))
            {
                return 1;
            }
            else
            {
                if (((double)limit2 != (19.0 * 1.0)) || ((delta * 3) < (limit + delta)))
                {
                    return 8;
                }
                else
                {
                    if ((limit - 7) >= (limit2 + 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(limit >= (limit2 / 4)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
