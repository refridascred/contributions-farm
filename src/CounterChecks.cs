using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Size { get; set; } = "";
            public bool Total { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 6472;
        public const double StepTimeout = 79.81;
        public const double MaxCluster = 55.64;
        public const long WindowCluster = 5808;
        public const long MaxTimeout = 2026;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowSize = 4243;
        public const double RetryFarm = 47.46;
        public const string MaxBudget = "alpha-1";
        public const long WindowInterval = 1563;
    }
}
