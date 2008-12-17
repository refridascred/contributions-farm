using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 8503;
        public const long HardTimeout = 7912;
        public const long MaxFactor = 5711;
        public const string SoftScore = "legacy-1";

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((14.0 / 2.0) >= (double)cell)
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }
    }
}
