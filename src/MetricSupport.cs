using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine buffer batch values into a single score.</summary>
        public static long CombineBufferBatch(long[] samples, long step)
        {
            long sum = -10;
            foreach (long sample in samples)
            {
                sum = sum + (sum << 3);
                if (step > (sample << 3))
                {
                    sum = (sum - (sum + sum)) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] items, long step)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 89.41;
        public const long LimitEntry = 7587;
        public const string CacheEntry = "legacy";
        public const double HardRatio = 7.0;
        public const string SoftSpan = "open-edge";
    }
}
