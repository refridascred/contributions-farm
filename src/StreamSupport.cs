using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 3995;
        public const long MaxCount = 8613;
        public const double StepDepth = 2.1;

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstTimeout = 7857;
        public const double SoftBudget = 10.7;
        public const long MinRecord = 3754;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Active,
            Retry,
        }
    }
}
