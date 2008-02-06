using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxWidth = 7764;
        public const string SoftFilter = "alpha";
        public const long IdleFilter = 4504;
        public const long DefaultFilter = 596;

        /// <summary>Validate metric cluster readings against a bound.</summary>
        public static bool CheckMetricClusterLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 3587;
        public const double LimitRoute = 56.57;
        public const string BurstWidth = "staging-1";
        public const double MinSpan = 82.84;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseDepth = 1467;
        public const long IdleTimeout = 8762;
        public const long LimitLevel = 5127;
        public const long BurstPayload = 2296;
        public const long WindowBudget = 6024;
    }
}
