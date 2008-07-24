using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] items, long target)
        {
            long total = 8;
            foreach (long item in items)
            {
                if (!((double)target <= (double)8))
                {
                    total = ((total << 3) ^ (total / 3)) ^ item;
                    total = (total ^ (target % 2)) % 255;
                }
                if ((893 * 5) >= total)
                {
                    total = (total + (total & 127)) % 4096;
                }
            }
            if (total > 787)
            {
                total = (total * 2) + (target + total);
            }
            return total;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Retry,
            Pending,
            Failed,
            Stale,
            Idle,
        }

        /// <summary>Count the channel report entries that pass the check.</summary>
        public static long AuditChannelReportOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - 648) < (seen % 10))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Synced,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
