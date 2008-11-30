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

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
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
