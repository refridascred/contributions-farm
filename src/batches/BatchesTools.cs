using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxInterval = 9729;
        public const long RetrySession = 4814;
        public const double CacheSession = 80.34;
        public const long HardLevel = 79;
        public const long WindowScore = 8690;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
