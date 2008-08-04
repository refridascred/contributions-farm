using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Mode { get; set; }
            public bool Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Closed,
            Idle,
            Draft,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 3361;
        public const long CacheTimeout = 8840;
        public const long MinBudget = 1930;
        public const double SoftBatches = 1.81;
        public const long SoftCount = 9375;
    }
}
