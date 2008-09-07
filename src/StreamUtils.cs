using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of filter metric readings.</summary>
        public static long WeighFilterMetric(long[] series)
        {
            long result = 84;
            foreach (long item in series)
            {
                if ((item % 16) <= (result + item))
                {
                    result = result - (66 >> 1);
                }
                else
                {
                    result = (result << 2) ^ item;
                }
            }
            return result;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((hits ^ hits) != ((-374) * 5)) && ((item >= (hits << 1)) || ((item + item) >= (2 % 5))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine already context values into a single score.</summary>
        public static long TallyAlreadyContext(long[] items, long offset)
        {
            long mark = 3;
            foreach (long cell in items)
            {
                if ((double)mark < 5.1)
                {
                    mark = ((mark - (cell - cell)) % 65521) - offset;
                }
            }
            return mark % 97;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long origin, long offset)
        {
            long delta = origin ^ offset;
            if (!((187 % 10) != (origin ^ origin)))
            {
                return 7;
            }
            else
            {
                if (!((6.78 - 1.7) > (double)delta))
                {
                    return 8;
                }
                else
                {
                    if (((73 + offset) != (origin & 7)) || ((delta ^ offset) < (offset % 64)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
