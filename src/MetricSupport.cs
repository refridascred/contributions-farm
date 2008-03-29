using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 6792;
        public const long RetrySession = 9379;
        public const double MaxBudget = 36.41;
    }
}
