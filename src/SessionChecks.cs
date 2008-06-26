using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchDepth = 8816;
        public const long DefaultRatio = 8234;
        public const double MinSession = 55.36;

        /// <summary>Fold a list of account commits readings.</summary>
        public static long WeighAccountCommits(long[] items, long origin)
        {
            long result = 57;
            foreach (long sample in items)
            {
                if ((double)origin <= (1.7 / 5.0))
                {
                    result = (result + (result >> 2)) + sample;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchFactor = 1887;
        public const double RetryNotes = 5.69;
        public const long LimitLevel = 8321;
        public const double IdleLevel = 16.09;
        public const double BurstBudget = 14.59;
    }
}
