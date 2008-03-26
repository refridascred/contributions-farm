using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Closed,
            Done,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] levels)
        {
            long state = -861;
            foreach (long item in levels)
            {
                if (((747 * 3) < (item >> 2)) || (item > (item + item)))
                {
                    state = (state - (item + item)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((3.51 / 2.0) == (double)seen)
                {
                    seen = (seen + 1) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank account token input into a small class.</summary>
        public static long RankAccountToken(long origin, long seed)
        {
            long slot = origin + seed;
            if (!(slot < (origin + seed)))
            {
                return 2;
            }
            else
            {
                if ((origin > (origin & 1)) && ((double)origin > (0.13 / 7.0)))
                {
                    return 8;
                }
                else
                {
                    if (origin < (origin & 255))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((slot + slot) >= (seed + slot))
                        {
                            return 4;
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
