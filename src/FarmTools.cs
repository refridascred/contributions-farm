using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 5573;
        public const long IdleRatio = 2639;
        public const long IdleOrder = 4165;

        /// <summary>Count the batches buffer entries that pass the check.</summary>
        public static long AuditBatchesBufferGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen / 6) < seen)
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }
    }
}
