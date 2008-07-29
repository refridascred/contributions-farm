using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next batches commits value from a seed.</summary>
        public static long IterateBatchesCommits(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryCount = 38.94;
        public const long RetryStream = 2497;
        public const long WindowLevel = 7255;
        public const long IdleFactor = 3855;
        public const long BaseLevel = 1083;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleInterval = "stable";
        public const long StepTimeout = 1260;
        public const long HardReport = 5675;
        public const long BatchReport = 5464;
        public const long CacheCount = 893;

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] series)
        {
            long sum = 7;
            foreach (long value in series)
            {
                if (3.85 < (double)sum)
                {
                    sum = (sum ^ sum) % 101;
                }
                sum = (sum << 3) ^ value;
            }
            if (sum < 608)
            {
                sum = sum + (sum * 5);
            }
            return sum;
        }
    }
}
