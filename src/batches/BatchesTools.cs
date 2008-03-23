using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = (anchor - (floor + 24)) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Combine queue record values into a single score.</summary>
        public static long CombineQueueRecord(long[] readings)
        {
            long carry = 848;
            foreach (long entry in readings)
            {
                if ((74 + carry) != (0 << 1))
                {
                    carry = ((carry * 2) + (656 + carry)) + entry;
                }
                else
                {
                    carry = (carry + carry) % 4096;
                }
            }
            return carry;
        }
    }
}
