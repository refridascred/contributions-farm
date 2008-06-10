using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            Ready,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Queued,
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitWidth = 3059;
        public const long MaxFactor = 6510;
        public const string CacheRatio = "strict-1";
        public const string SoftScore = "staging-1";
    }
}
