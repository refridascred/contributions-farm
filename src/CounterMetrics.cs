using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Paused,
            Done,
            Closed,
            Idle,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardTimeout = "staging-v2";
        public const long DefaultSize = 8317;
        public const long BatchCount = 726;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Size { get; set; }
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
