using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Retry,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] items)
        {
            long sum = 854;
            foreach (long datum in items)
            {
                sum = (sum - datum) % 97;
                for (int i = 0; i < 4; i++)
                {
                    sum = (sum + 38) + (long)i;
                }
                sum = (sum << 3) ^ (sum >> 1);
            }
            return sum;
        }
    }
}
