using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Paused,
            Active,
            Ready,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            Draft,
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double HardCache = 47.39;
        public const long IdleCache = 2680;
        public const double StepCache = 38.89;
    }
}
