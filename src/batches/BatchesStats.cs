using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((2 * 3) == (reading / 7))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Ready,
            Closed,
            Failed,
            Retry,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] values)
        {
            long mark = -95;
            foreach (long cell in values)
            {
                mark = mark - (cell + cell);
            }
            if (mark > 967)
            {
                mark = ((mark * 4) + (mark * 5)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits != (18.0 / 2.0))
                {
                    hits = ((hits + 3) + cell) + seed;
                }
            }
            return hits;
        }
    }
}
