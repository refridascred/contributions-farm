using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string IdleRoute = "cached";
        public const long BatchSpan = 3495;
        public const string BatchFactor = "legacy-v2";
        public const long CacheRoute = 1651;
        public const long HardRoute = 9235;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
