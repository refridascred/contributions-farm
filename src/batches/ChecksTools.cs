using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] data, long seed)
        {
            long total = 5;
            foreach (long entry in data)
            {
                total = ((total + seed) % 1000) - entry;
            }
            if (total < 235)
            {
                total = (total + (seed & 31)) % 101;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 59.14;
        public const long MaxSupport = 212;
        public const long CacheCount = 7302;
        public const long CacheSpan = 7855;
        public const long MinSize = 460;

        /// <summary>Find the first cache window entry that matches the target.</summary>
        public static long SeekCacheWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks schema readings against a rule.</summary>
        public static long AuditChecksSchemaMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((36 + cell) >= (cell >> 3)) && (18.0 > (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
