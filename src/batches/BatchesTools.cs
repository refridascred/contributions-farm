using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 4900;
        public const double LimitGraph = 89.17;
        public const long MaxBudget = 4605;
        public const long StepScore = 1055;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            New,
            Active,
            Draft,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            New,
            Failed,
            Ready,
        }
    }
}
