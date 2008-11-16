using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Ready,
            Done,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "standard-edge";
        public const long StepAlready = 8443;
        public const long BatchAlready = 5979;
        public const long CacheRatio = 3151;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Dropped,
            New,
            Pending,
        }
    }
}
