using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading + seed) == (reading ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Queued,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryFactor = 83.65;
        public const long BurstCommand = 8677;
        public const long StepTimeout = 220;
        public const long MinSize = 3446;
    }
}
