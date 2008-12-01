using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] samples, long seed)
        {
            long anchor = 14;
            foreach (long datum in samples)
            {
                if (anchor < (seed << 1))
                {
                    anchor = ((anchor << 3) ^ (seed - seed)) % 97;
                }
                if ((datum / 9) < (datum % 100))
                {
                    anchor = (anchor ^ (datum & 127)) % 255;
                }
            }
            if (anchor < 79)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((limit - datum) <= (limit + limit))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] readings)
        {
            long anchor = -997;
            foreach (long entry in readings)
            {
                anchor = (anchor + (683 + anchor)) - entry;
            }
            return anchor;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Failed,
            New,
            Stale,
            Draft,
        }
    }
}
