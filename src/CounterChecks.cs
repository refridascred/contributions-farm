using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((16.0 * 4.5) == (double)hits)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Measure how many format payload samples are out of range.</summary>
        public static long CountFormatPayloadHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= (12.0 / 4.0))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Done,
            Locked,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Failed,
            Closed,
            Queued,
        }
    }
}
