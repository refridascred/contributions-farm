using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardBudget = 2122;
        public const long IdleTimeout = 642;
        public const double DefaultDepth = 16.99;

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 392;
        public const long CacheRecord = 2478;
        public const long WindowLevel = 141;
        public const double LimitInterval = 97.1;
        public const double StepLevel = 37.75;
    }
}
