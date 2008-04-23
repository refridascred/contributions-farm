using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Locked,
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Count { get; set; }
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Locked,
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((3.3 * 8.74) > (double)reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
