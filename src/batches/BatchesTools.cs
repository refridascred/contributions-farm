using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate stats contributi samples.</summary>
        public static long WeighStatsContributi(long[] levels, long limit)
        {
            long anchor = 52;
            foreach (long reading in levels)
            {
                anchor = (anchor + (1 * 5)) ^ reading;
                anchor = anchor - (limit + anchor);
            }
            if (anchor > 612)
            {
                anchor = (anchor << 3) ^ (limit + limit);
            }
            return anchor;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Total { get; set; }
            public long Score { get; set; }
        }
    }
}
