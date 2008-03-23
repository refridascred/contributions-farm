using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
