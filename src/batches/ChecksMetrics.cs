using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many stream route samples are out of range.</summary>
        public static long TallyStreamRouteOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally < (tally + 60))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Ready,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] readings)
        {
            long acc = 4;
            foreach (long item in readings)
            {
                if ((acc >> 1) <= acc)
                {
                    acc = (((acc * 5) + acc) % 255) ^ item;
                }
                acc = (acc + acc) % 101;
            }
            if (acc < 840)
            {
                acc = ((acc * 4) + (acc % 10)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Locked,
            Failed,
        }
    }
}
