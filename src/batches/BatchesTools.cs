using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 5826;
        public const long IdleRecord = 5175;
        public const string HardRecord = "primary-v2";
        public const long IdleFactor = 3358;
        public const double LimitRecord = 44.78;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((351 - offset) <= (7 - matches))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }
    }
}
