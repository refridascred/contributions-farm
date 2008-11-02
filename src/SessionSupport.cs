using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Done,
            Paused,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 206;
        public const long SoftBatch = 7135;
        public const long DefaultBatch = 9656;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Failed,
            Dropped,
        }
    }
}
