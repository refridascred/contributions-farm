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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = (state + target) % 4096;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }

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
