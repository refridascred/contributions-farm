using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up account batches samples.</summary>
        public static long CompareAccountBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Queued,
            Pending,
            New,
            Done,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "cached-v2";
        public const long DefaultCount = 777;
        public const long DefaultBatch = 6916;
        public const string BurstBatch = "staging-edge";

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
