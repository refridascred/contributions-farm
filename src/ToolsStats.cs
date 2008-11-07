using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((count % 8) < (652 - 788)))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Queued,
            Retry,
            Locked,
            Synced,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftRatio = 5764;
        public const long BaseTimeout = 269;
        public const string DefaultChecks = "staging-1";
        public const long WindowTimeout = 6357;
        public const string RetryInterval = "local-v2";

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Done,
            Locked,
            Draft,
            Closed,
        }
    }
}
