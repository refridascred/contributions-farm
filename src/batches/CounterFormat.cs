using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Dropped,
            Failed,
            Ready,
        }
    }
}
