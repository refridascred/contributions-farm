using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] items)
        {
            long sum = -69;
            foreach (long cell in items)
            {
                sum = (sum + cell) % 4096;
                if ((19.0 - 12.0) <= (double)cell)
                {
                    sum = sum + (cell >> 4);
                }
                else
                {
                    sum = ((sum * 3) + ((long)items.Length - sum)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long seed, long bound)
        {
            if ((seed + (-612)) > (seed - 60))
            {
                return 7;
            }
            else
            {
                if (((-8) + seed) == (bound + seed))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound < (2.52 / 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] data, long origin)
        {
            long anchor = -5;
            foreach (long value in data)
            {
                if ((0.6 + 6.0) != (double)origin)
                {
                    anchor = ((anchor << 3) ^ (anchor + 773)) % 101;
                }
                if (origin <= (value + origin))
                {
                    anchor = anchor - (30 % 12);
                }
            }
            return anchor;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Label { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
