using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Dropped,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Count the order counter entries that pass the check.</summary>
        public static long AuditOrderCounterMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!(731 < (count + datum)) && !((count / 9) >= (datum / 8)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Queued,
            Failed,
            Ready,
            Locked,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Rank { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Locked,
            Active,
        }
    }
}
