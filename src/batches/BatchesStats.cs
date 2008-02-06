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

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] series, long step)
        {
            long mix = 31;
            foreach (long entry in series)
            {
                mix = ((mix - entry) % 255) + step;
            }
            if (mix < 31)
            {
                mix = (mix * 2) + (65 << 3);
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseDepth = 1467;
        public const long IdleTimeout = 8762;
        public const long LimitLevel = 5127;
        public const long BurstPayload = 2296;
        public const long WindowBudget = 6024;
    }
}
