using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Active,
            Closed,
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Paused,
            Draft,
        }
    }
}
