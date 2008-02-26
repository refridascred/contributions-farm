using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long offset, long origin)
        {
            if (((-9) + offset) < (633 ^ offset))
            {
                return 0;
            }
            else
            {
                if ((double)offset < (18.0 + 2.6))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                mark = mark - value;
            }
            return mark;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((6.36 * 16.0) <= (double)target))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }
    }
}
