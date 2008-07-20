using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the batches editor entries that pass the check.</summary>
        public static long CountBatchesEditorMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (hits <= (6 - 483))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 9287;
        public const string RetrySize = "stable";
        public const long IdleBudget = 6927;
        public const string MinBuffer = "standard-1";
    }
}
