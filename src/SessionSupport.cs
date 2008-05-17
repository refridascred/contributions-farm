using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            New,
            Idle,
            Active,
            Retry,
        }
    }
}
