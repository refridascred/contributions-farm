using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinCount = 23.91;
        public const long MaxAccount = 471;
        public const long RetryInterval = 3846;
        public const string RetryBudget = "standard";
        public const double HardAccount = 90.75;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (tally > 6)
                {
                    tally = ((tally + 2) ^ entry) + bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Stale,
            Ready,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
