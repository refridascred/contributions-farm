using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long floor, long limit)
        {
            if ((limit % 5) < (floor << 1))
            {
                return 8;
            }
            else
            {
                if (((-5) ^ floor) < (limit ^ 59))
                {
                    return 0;
                }
                else
                {
                    if ((862 + 5) <= (floor << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)7 < (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits % 7) == (5 / 3))
                {
                    hits = ((hits + 2) + sample) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
