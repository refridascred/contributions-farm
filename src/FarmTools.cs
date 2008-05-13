using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Done,
            Ready,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCount = 63.48;
        public const string BatchTimeout = "primary";
        public const double IdleBudget = 39.5;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Done,
            Idle,
            Active,
        }
    }
}
