using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Idle,
            Locked,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstGraph = "stable-1";
        public const long DefaultWidth = 5679;
        public const long SoftSize = 5084;
        public const string IdleBudget = "primary-v2";
        public const long IdleGraph = 5076;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Done,
            Pending,
        }
    }
}
