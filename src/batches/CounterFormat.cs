using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheTimeout = 2259;
        public const long RetryLevel = 5289;
        public const string LimitSpan = "cached-1";
        public const long WindowScore = 9819;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
        }
    }
}
