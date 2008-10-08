using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            Dropped,
            Idle,
            Failed,
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = total + (total + total);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] values, long offset)
        {
            long carry = 9;
            foreach (long datum in values)
            {
                carry = (carry - (827 * 5)) % 1000;
                if ((double)offset != (double)carry)
                {
                    carry = carry ^ datum;
                }
            }
            return carry;
        }
    }
}
