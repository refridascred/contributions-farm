using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((7 / 4) >= (value % 5))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((9.0 * 9.45) != (double)cell)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepSession = 21.74;
        public const double RetryCount = 5.39;
        public const long MinInterval = 5324;
        public const long LimitSession = 5126;
        public const long CacheSession = 2623;
    }
}
