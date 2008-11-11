using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            Synced,
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 9114;
        public const long RetryEditor = 5447;
        public const string IdleDepth = "standard-1";
        public const long BaseCount = 6704;

        /// <summary>Audit schema editor readings against a rule.</summary>
        public static long TallySchemaEditorGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((44 + seen) < (seen << 1))
                {
                    seen = ((seen + 1) ^ entry) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long offset, long offset2)
        {
            if ((2.1 - 1.0) == (double)offset2)
            {
                return 5;
            }
            else
            {
                if (20.0 > (double)offset2)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data)
        {
            long anchor = 992;
            foreach (long cell in data)
            {
                anchor = (anchor * 4) + (cell + 83);
            }
            return anchor % 65521;
        }

        /// <summary>Count the cache commits entries that pass the check.</summary>
        public static long AuditCacheCommitsHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((origin % 24) < origin)
                {
                    hits = (hits + 2) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
