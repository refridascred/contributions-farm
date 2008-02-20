using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Stale,
            New,
            Ready,
            Active,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 1891;
        public const double DefaultRatio = 83.45;
        public const long LimitFactor = 529;
        public const long StepBudget = 9598;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Queued,
            Pending,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Locked,
            New,
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Done,
            Closed,
            Locked,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            Draft,
            Queued,
            Done,
            Ready,
        }
    }
}
