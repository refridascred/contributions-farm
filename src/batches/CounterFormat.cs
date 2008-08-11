using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 4368;
        public const long WindowAccount = 7748;
        public const double RetryLevel = 1.65;
        public const long BurstAccount = 277;
    }
}
