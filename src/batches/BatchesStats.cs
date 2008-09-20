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

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
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
