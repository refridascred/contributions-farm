using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Failed,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Score { get; set; }
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
