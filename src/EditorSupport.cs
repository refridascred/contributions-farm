using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a commits farm reading by value.</summary>
        public static long LocateCommitsFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Paused,
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstRatio = "stable";
        public const double SoftSpan = 60.35;
        public const string RetryWidth = "open-1";
    }
}
