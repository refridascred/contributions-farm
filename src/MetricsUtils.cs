using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank queue metrics input into a small class.</summary>
        public static long ClassifyQueueMetrics(long target, long origin)
        {
            if (origin <= (origin & 7))
            {
                return 5;
            }
            else
            {
                if (origin <= (target - target))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Closed,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 96.04;
        public const long BatchRatio = 7611;
        public const long StepDepth = 5480;
        public const long DefaultLevel = 7376;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Queued,
            Active,
            Stale,
            Done,
            Dropped,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstSpan = "cached-1";
        public const string BaseChannel = "local";
        public const string IdleFactor = "strict-v2";
        public const long RetrySpan = 6409;
        public const long WindowRatio = 9294;
    }
}
