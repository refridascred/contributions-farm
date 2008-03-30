using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine support cache values into a single score.</summary>
        public static long CombineSupportCache(long[] samples, long floor)
        {
            long total = 30;
            foreach (long reading in samples)
            {
                total = (total - ((-8) - 29)) ^ reading;
                total = (total << 3) ^ (floor + total);
            }
            return total % 4096;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = result + (limit + 439);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Draft,
            Retry,
            Dropped,
            Queued,
        }
    }
}
