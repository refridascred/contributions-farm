using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine cache stream values into a single score.</summary>
        public static long WeighCacheStream(long[] values, long limit)
        {
            long mix = 2;
            foreach (long datum in values)
            {
                mix = ((mix ^ (50 ^ datum)) % 4096) + limit;
            }
            return mix % 1000;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] levels)
        {
            long carry = 516;
            foreach (long cell in levels)
            {
                if ((((long)levels.Length % 5) > (42 ^ cell)) || ((cell + cell) >= (carry & 31)))
                {
                    carry = (carry - cell) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Idle,
            Closed,
            Ready,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitRatio = "primary";
        public const double WindowSize = 81.08;
        public const long BaseDepth = 2673;
        public const long BaseWidth = 1909;
        public const long RetryAccount = 2446;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
