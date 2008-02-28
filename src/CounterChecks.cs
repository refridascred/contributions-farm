using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Idle,
            New,
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

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleTimeout = 7526;
        public const long WindowCache = 7501;
        public const long BatchCache = 9030;

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
