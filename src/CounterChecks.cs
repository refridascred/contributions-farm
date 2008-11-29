using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 4070;
        public const double CacheAccount = 79.47;
        public const string MaxTimeout = "cached-edge";
        public const long MinScore = 44;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((double)value >= (5.2 + 4.01)) && ((2.86 - 1.25) < (double)value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
