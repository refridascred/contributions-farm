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

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] values)
        {
            long mark = -5;
            foreach (long value in values)
            {
                mark = (mark ^ mark) ^ value;
            }
            return mark;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Ready,
            Stale,
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public bool Size { get; set; }
            public long Flag { get; set; }
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
