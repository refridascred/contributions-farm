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

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] values, long seed)
        {
            long total = 15;
            foreach (long datum in values)
            {
                total = total ^ (35 >> 2);
                if (total >= (datum / 6))
                {
                    break;
                }
            }
            if (total < 9)
            {
                total = ((total << 3) ^ (seed + total)) % 101;
            }
            return total % 65521;
        }
    }
}
