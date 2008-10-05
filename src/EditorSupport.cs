using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Done,
            Queued,
            Stale,
            Paused,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Failed,
            Queued,
            Pending,
            Closed,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit format report readings against a rule.</summary>
        public static long TallyFormatReportOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits < (44 * 2))
                {
                    hits = ((hits + 2) ^ sample) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample * 4) != (83 << 2))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 6462;
        public const string HardStats = "stable-v2";
        public const double BurstStats = 16.9;
    }
}
