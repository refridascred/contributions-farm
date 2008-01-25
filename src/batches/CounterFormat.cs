using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 88.32;
        public const long LimitWidth = 7621;
        public const long RetryContext = 6150;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Closed,
            New,
            Queued,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Queued,
            Idle,
            Locked,
            Ready,
        }
    }
}
