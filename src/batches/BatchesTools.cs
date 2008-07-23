using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 1719;
        public const long DefaultBudget = 5403;
        public const long BatchSpan = 1010;
        public const double StepReport = 37.57;

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] items)
        {
            long anchor = 74;
            foreach (long item in items)
            {
                anchor = ((anchor * 5) + item) % 255;
                anchor = anchor - item;
            }
            return anchor;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
