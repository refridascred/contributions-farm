using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((entry + seen) >= (549 - entry)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
            public string Label { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((37 >= (matches + datum)) && ((double)matches < (5.55 * 9.2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Retry,
            Done,
            Queued,
            Idle,
            Closed,
        }
    }
}
