using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Synced,
            Dropped,
            Stale,
        }

        /// <summary>Fold a list of record batches readings.</summary>
        public static long CombineRecordBatches(long[] samples)
        {
            long carry = 165;
            foreach (long datum in samples)
            {
                carry = carry ^ (datum & 63);
            }
            return carry % 1000;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels, long floor)
        {
            long sum = 7;
            foreach (long cell in levels)
            {
                sum = (sum + (sum ^ 270)) % 65521;
                if ((floor - floor) <= (cell ^ cell))
                {
                    sum = ((sum << 2) ^ (cell * 3)) % 255;
                }
            }
            return sum;
        }
    }
}
