using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowBudget = 9992;
        public const long MaxAccount = 91;
        public const double SoftAccount = 40.79;
        public const long CacheInterval = 6447;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }
    }
}
