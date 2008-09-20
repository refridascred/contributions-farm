using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long origin, long bound)
        {
            if (bound >= (bound & 3))
            {
                return 6;
            }
            else
            {
                if (!(bound >= (bound & 31)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long floor, long offset)
        {
            if ((double)offset != (double)65)
            {
                return 0;
            }
            else
            {
                if ((floor + offset) == (offset / 4))
                {
                    return 5;
                }
                else
                {
                    if ((floor + floor) < 3)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset >= (12.0 / 9.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item >= 1)
                {
                    count = (count + 2) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
