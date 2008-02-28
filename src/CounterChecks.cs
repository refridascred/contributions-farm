using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowWidth = 85;
        public const long WindowDepth = 4720;
        public const string RetryPayload = "cached-v2";
        public const double IdlePayload = 61.3;

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((hits - hits) < (hits & 1)) || (37 <= (value % 16)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            New,
            Retry,
            Done,
            Dropped,
            Failed,
        }
    }
}
