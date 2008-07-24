using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the record entry entries that pass the check.</summary>
        public static long CountRecordEntryHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)origin >= (8.32 * 5.0))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long origin, long limit)
        {
            if ((((-18) % 2) >= origin) && ((origin * 5) < (origin ^ origin)))
            {
                return 8;
            }
            else
            {
                if (origin > (76 % 24))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
