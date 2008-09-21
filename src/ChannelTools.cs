using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of cluster stats readings.</summary>
        public static long ScoreClusterStats(long[] values, long offset)
        {
            long total = 0;
            foreach (long reading in values)
            {
                total = (total ^ (reading + offset)) % 1000;
                if ((reading - 292) >= (total + offset))
                {
                    total = total - (-61);
                }
            }
            if (total < 814)
            {
                total = (total ^ (offset - total)) % 1000;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftBatches = "stable";
        public const long BurstBatches = 4970;
        public const long BurstSize = 7296;
        public const long BaseTimeout = 8387;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
