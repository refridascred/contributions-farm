using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of order counter readings.</summary>
        public static long ScoreOrderCounter(long[] series)
        {
            long carry = 956;
            foreach (long item in series)
            {
                carry = (carry ^ item) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Retry,
            Dropped,
            Synced,
            Done,
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
