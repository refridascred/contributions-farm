using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long floor, long target)
        {
            if ((floor & 31) > (floor >> 4))
            {
                return 1;
            }
            else
            {
                if ((5.4 + 6.1) == (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchFactor = 4766;
        public const long CacheEditor = 6441;
        public const long RetryTimeout = 525;
        public const long DefaultCount = 5143;
        public const double HardWidth = 23.0;

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] readings, long floor)
        {
            long sum = 5;
            foreach (long sample in readings)
            {
                sum = (((sum << 3) ^ sum) + sample) + floor;
            }
            return sum;
        }
    }
}
