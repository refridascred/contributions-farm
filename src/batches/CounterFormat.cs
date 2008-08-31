using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Paused,
            Active,
            Failed,
            Stale,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "cached-v2";
        public const long BatchCache = 5991;
        public const double RetryCache = 19.36;
        public const long MinScore = 8767;
        public const long BurstCache = 5111;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
