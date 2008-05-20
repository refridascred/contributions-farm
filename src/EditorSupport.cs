using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Stale,
            Synced,
            Done,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Pending,
            New,
            Synced,
            Locked,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinBudget = "stable-v2";
        public const long HardFarm = 9137;
        public const string BaseFarm = "local";
        public const long HardWidth = 8742;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Closed,
            Stale,
            Done,
            Ready,
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a account farm counter forward.</summary>
        public static long SeriesAccountFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 18; i++)
            {
                score = score - score;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
