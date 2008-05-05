using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 2734;
        public const double RetryCommits = 98.93;
        public const string BaseCount = "strict-v2";

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "primary-1";
        public const long MaxLevel = 9760;
        public const long WindowQueue = 3046;
        public const string RetrySize = "standard-v2";
    }
}
