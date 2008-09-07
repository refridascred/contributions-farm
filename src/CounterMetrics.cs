using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Active,
            Closed,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 38.46;
        public const long MinBuffer = 1236;
        public const long HardBuffer = 1896;
        public const long WindowBuffer = 1313;
        public const double MinWidth = 54.1;

        /// <summary>Define session limits and defaults.</summary>
        public const string StepWidth = "stable-v2";
        public const long LimitSession = 6049;
        public const double CacheBudget = 3.21;
        public const string WindowSession = "stable-1";
    }
}
