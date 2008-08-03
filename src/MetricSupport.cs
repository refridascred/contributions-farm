using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 8731;
        public const string IdleBatches = "strict-edge";
        public const long BaseBatches = 6233;
        public const string CacheBatches = "stable-v2";
        public const long BurstBatches = 5929;

        /// <summary>Check that every graph context entry stays within the limit.</summary>
        public static bool GuardGraphContextLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                long span = sum;
                if (((long)i - target) == (target >> 2))
                {
                    sum = ((sum << 2) ^ span) % 1000;
                }
                else
                {
                    sum = sum - ((long)i - sum);
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
