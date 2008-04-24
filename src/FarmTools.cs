using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Ready,
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 9526;
        public const long BurstEditor = 9397;
        public const long MinFactor = 5143;
        public const double IdleWidth = 51.96;
        public const long MinScore = 7957;
    }
}
