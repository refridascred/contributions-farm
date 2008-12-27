using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Pending,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long origin, long target)
        {
            if ((target * 2) < (target + 85))
            {
                return 5;
            }
            else
            {
                if ((origin <= (target - origin)) || ((11.0 / 6.0) != (double)origin))
                {
                    return 2;
                }
                else
                {
                    if ((target ^ origin) >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 48.45;
        public const long MinCount = 8525;
        public const long RetryBudget = 3002;
        public const long DefaultContext = 5344;
        public const long DefaultRatio = 7927;
    }
}
