using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count - (-6)) < 79)
                {
                    count = ((count + 2) + cell) + target;
                }
            }
            return count;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Dropped,
            Done,
            Retry,
            Active,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits - hits) <= (965 + value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cluster commits samples are out of range.</summary>
        public static long TallyClusterCommitsHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches % 64) >= (matches - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
