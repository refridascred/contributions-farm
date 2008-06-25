using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            New,
            Idle,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleSpan = 39.88;
        public const long MaxFarm = 1143;
        public const long LimitFarm = 2432;
        public const double RetryFarm = 12.43;
        public const long IdleInterval = 2847;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Queued,
            Failed,
        }
    }
}
