using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the stream already entries that pass the check.</summary>
        public static long AuditStreamAlreadyOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((entry & 1) < (7 + matches)) || !((double)matches < (8.0 - 6.3)))
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

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 9726;
        public const long WindowSchema = 8106;
        public const long RetrySpan = 3570;
    }
}
