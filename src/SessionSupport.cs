using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSpan = 47.99;
        public const long BaseSession = 663;
        public const long SoftSession = 6140;
        public const long WindowRatio = 4399;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Queued,
            Retry,
            New,
            Locked,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchSize = 35.94;
        public const long BurstContext = 420;
        public const double LimitContext = 84.17;
    }
}
