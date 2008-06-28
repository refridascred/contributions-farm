using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepDepth = 675;
        public const double MinToken = 59.81;
        public const long BaseWidth = 9502;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Active,
            Paused,
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Synced,
            Locked,
        }
    }
}
