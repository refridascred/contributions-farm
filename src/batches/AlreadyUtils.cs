using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Synced,
            Active,
            Done,
            Locked,
            Pending,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 3) + (acc + (long)i)) % 4096;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((94 ^ entry) <= (275 - entry)) && ((entry * 2) < (seen + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 1577;
        public const double CacheAccount = 62.68;
        public const long SoftAccount = 6167;
        public const string WindowDepth = "strict-edge";
        public const double IdleSpan = 5.44;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((limit ^ cell) > (95 % 60))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
