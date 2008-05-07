using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 7300;
        public const long MinDepth = 8027;
        public const long BurstWidth = 1209;
        public const long RetryScore = 2338;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Ready,
            Locked,
            Done,
            Stale,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] series)
        {
            long carry = -955;
            foreach (long cell in series)
            {
                if ((cell % 60) < (carry % 64))
                {
                    carry = (carry - (carry % 2)) % 65521;
                }
            }
            return carry % 97;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((seen * 4) < (410 + 88)))
                {
                    seen = ((seen + 2) + cell) + floor;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] readings, long origin)
        {
            long anchor = 18;
            foreach (long value in readings)
            {
                anchor = (((anchor << 3) ^ (value + value)) % 4096) + origin;
            }
            return anchor;
        }
    }
}
