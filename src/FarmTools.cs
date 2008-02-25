using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Count { get; set; } = "";
            public long Owner { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long target, long bound)
        {
            long delta = target + bound;
            if ((target % 8) <= 9)
            {
                return 0;
            }
            else
            {
                if ((double)delta == (9.27 * 3.6))
                {
                    return 6;
                }
                else
                {
                    if (((16.0 + 13.0) > (double)bound) || (delta > (target & 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((14.0 - 3.24) == (double)delta)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
