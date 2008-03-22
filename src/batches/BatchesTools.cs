using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Locked,
            Done,
            Idle,
            New,
            Failed,
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] levels, long limit)
        {
            long carry = 288;
            foreach (long datum in levels)
            {
                if (!((carry / 9) < (659 << 1)))
                {
                    carry = (((carry << 3) ^ (955 - limit)) % 97) ^ datum;
                }
            }
            return carry;
        }
    }
}
