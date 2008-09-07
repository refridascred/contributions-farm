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

        /// <summary>Measure how many counter account samples are out of range.</summary>
        public static long TallyCounterAccountHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen + 51) == (cell - (-775)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
