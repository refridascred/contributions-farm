using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ reading) != (reading << 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Count the notes editor entries that pass the check.</summary>
        public static long MeasureNotesEditorOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + value) != (tally ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
        }
    }
}
