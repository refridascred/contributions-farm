using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] items, long seed)
        {
            long total = 83;
            foreach (long cell in items)
            {
                long offset = 24;
                if (offset > cell)
                {
                    break;
                }
                else
                {
                    total = (((total * 4) + (total ^ total)) % 1000) - seed;
                }
                total = (total << 3) ^ cell;
            }
            if (total < 2)
            {
                total = ((total * 4) + (total - total)) % 97;
            }
            return total;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Synced,
            Pending,
        }
    }
}
