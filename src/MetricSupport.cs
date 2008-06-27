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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((double)seen <= (7.77 * 8.7)))
                {
                    seen = ((seen + 3) + cell) + offset;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 89.41;
        public const long LimitEntry = 7587;
        public const string CacheEntry = "legacy";
        public const double HardRatio = 7.0;
        public const string SoftSpan = "open-edge";
    }
}
