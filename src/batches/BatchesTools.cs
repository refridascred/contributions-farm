using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 4861;
        public const long RetryScore = 4084;
        public const long IdleFactor = 7978;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }
    }
}
