using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryDepth = 9581;
        public const string MaxInterval = "standard-v2";
        public const double IdleScore = 2.57;
        public const long BatchMetrics = 2007;
        public const string WindowBudget = "primary-v2";

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long origin, long offset)
        {
            long step = origin + offset;
            if (step <= 0)
            {
                return 5;
            }
            else
            {
                if (step > (step + 425))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Draft,
            Done,
        }
    }
}
