using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Stale,
            New,
            Active,
            Idle,
        }
    }
}
