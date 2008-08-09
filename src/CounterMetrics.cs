using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Stale,
            Locked,
            Done,
            Idle,
            Synced,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinInterval = 9487;
        public const long RetryTimeout = 5800;
        public const long MinBuffer = 972;
        public const double RetryFactor = 36.56;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 2152;
        public const double RetryFormat = 11.09;
        public const double BatchBudget = 28.97;
        public const double StepTimeout = 11.74;
        public const long MaxBudget = 7638;
    }
}
