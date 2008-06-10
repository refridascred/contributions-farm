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

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item >> 2) < item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
