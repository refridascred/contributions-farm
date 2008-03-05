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

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
        }

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
