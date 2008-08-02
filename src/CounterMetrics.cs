using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 1061;
        public const long MaxSession = 5474;
        public const double IdleCount = 0.31;
        public const long LimitSession = 5577;
        public const long StepScore = 9371;

        /// <summary>Check that every farm channel entry stays within the limit.</summary>
        public static bool VerifyFarmChannelRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long origin, long bound)
        {
            if (bound < origin)
            {
                return 4;
            }
            else
            {
                if ((bound < (bound + origin)) || ((double)bound != (0.86 + 4.0)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
