using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the context batches entries that pass the check.</summary>
        public static long TallyContextBatchesHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (matches <= (matches / 2))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Failed,
            Draft,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Rank { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 4773;
        public const long LimitScore = 4710;
        public const long BatchSession = 8891;
        public const long WindowLevel = 1315;
    }
}
