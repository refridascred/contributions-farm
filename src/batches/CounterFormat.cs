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

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepSpan = 5510;
        public const long BatchCount = 4891;
        public const long BaseScore = 8115;
        public const long BaseInterval = 3923;
        public const long HardChecks = 5856;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
        }
    }
}
