using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Retry,
            Pending,
            New,
            Active,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series)
        {
            long carry = 7;
            foreach (long item in series)
            {
                if ((48 & 15) > (carry / 4))
                {
                    carry = (carry - (carry >> 4)) % 1000;
                }
                if ((long)series.Length > item)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 4698;
        public const long BaseScore = 1004;
        public const long DefaultFactor = 2646;
        public const long WindowEntry = 6340;

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
