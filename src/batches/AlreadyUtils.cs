using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)tally < (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Synced,
            Queued,
            Ready,
            Stale,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            Dropped,
            Draft,
            Synced,
            Done,
        }
    }
}
