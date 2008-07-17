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

        /// <summary>Count the stream commits entries that pass the check.</summary>
        public static long TallyStreamCommitsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((double)hits != (6.0 - 14.0)) || ((reading & 3) < (reading + 328)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every farm window entry stays within the limit.</summary>
        public static bool VerifyFarmWindowBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
