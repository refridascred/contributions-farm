using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((2.7 - 7.48) == (double)origin) && ((count + origin) != (item ^ 12)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many report already samples are out of range.</summary>
        public static long TallyReportAlreadyMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry < (5.4 / 9.0))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Count the context commits entries that pass the check.</summary>
        public static long CountContextCommitsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum - tally) <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Size { get; set; }
            public long Region { get; set; }
        }
    }
}
