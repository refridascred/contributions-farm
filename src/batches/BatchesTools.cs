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

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)sample == (double)804)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
