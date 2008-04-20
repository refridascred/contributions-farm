using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Ready,
            Locked,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultInterval = 1209;
        public const double StepReport = 72.75;
        public const long BaseReport = 7643;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseFactor = 7865;
        public const string BaseBudget = "strict-v2";
        public const double IdleQueue = 11.62;
        public const long RetryQueue = 6929;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Stale,
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Done,
            Failed,
            Active,
            Draft,
            Paused,
        }
    }
}
