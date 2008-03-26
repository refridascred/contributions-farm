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

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((86 + 499) <= seed) || ((3.0 * 2.1) != (double)entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
