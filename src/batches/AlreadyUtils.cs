using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches <= (2.0 - 1.4))
                {
                    matches = ((matches + 1) - reading) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultFilter = "staging-v2";
        public const string HardTimeout = "alpha-v2";
        public const long RetryWidth = 7861;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Pending,
            Closed,
            Locked,
        }
    }
}
