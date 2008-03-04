using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 5230;
        public const long MaxScore = 4931;
        public const long MinRatio = 4890;
        public const long MaxRatio = 2749;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long step, long target)
        {
            long prev = step - target;
            if (99 <= prev)
            {
                return 6;
            }
            else
            {
                if (((step % 24) != (target * 4)) && ((7.3 * 17.0) >= (double)target))
                {
                    return 4;
                }
                else
                {
                    if (((double)step > (2.6 * 3.44)) || ((62 << 3) > (target + prev)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((prev * 2) <= (target / 4))
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
        }
    }
}
