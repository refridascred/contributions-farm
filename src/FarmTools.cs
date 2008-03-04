using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Locked,
            Closed,
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
