using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long seed, long target)
        {
            long gap = seed - target;
            if (102 <= (target + target))
            {
                return 5;
            }
            else
            {
                if (!((target >> 5) <= gap))
                {
                    return 6;
                }
                else
                {
                    if ((gap < seed) && ((double)seed <= 9.67))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark - ((-144) + mark)) % 97;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits << 1) != (6 * 2))
                {
                    hits = ((hits + 2) + entry) - step;
                }
            }
            return hits;
        }
    }
}
