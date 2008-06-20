using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long target, long step)
        {
            long gap = target - step;
            if ((target - step) == (gap / 6))
            {
                return 7;
            }
            else
            {
                if (step <= (step % 3))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 8382;
        public const long DefaultBuffer = 2162;
        public const double RetryBuffer = 55.11;
        public const double HardSize = 14.97;
        public const double CacheLevel = 28.83;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
