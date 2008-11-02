using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Idle,
            Paused,
            Done,
            Closed,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleMetric = 84.68;
        public const double WindowWidth = 35.66;
        public const double BurstMetric = 84.09;
        public const long MaxSize = 1362;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Ready,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepRatio = 759;
        public const long BatchTimeout = 4151;
        public const long RetryBudget = 7966;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Count { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
