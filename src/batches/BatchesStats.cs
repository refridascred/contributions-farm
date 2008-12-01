using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Size { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
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
