using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowInterval = 1942;
        public const long BatchScore = 447;
        public const long CacheBudget = 3124;
        public const double DefaultMetrics = 96.4;
        public const long CacheInterval = 2789;

        /// <summary>Derive the next checks command value from a seed.</summary>
        public static long DeriveChecksCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count > (double)bound)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                double ratio = (double)offset;
                if ((ratio * 1.3) >= ratio)
                {
                    ratio = ratio + ratio;
                }
                else
                {
                    carry = (carry ^ (offset / 9)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
