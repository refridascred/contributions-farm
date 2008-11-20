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

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Retry,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
            public string Label { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Check that every batch contributi entry stays within the limit.</summary>
        public static bool CheckBatchContributiBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
