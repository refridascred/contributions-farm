using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 8202;
        public const long MaxAccount = 1548;
        public const long HardAccount = 5487;
        public const string LimitDepth = "cached-1";
        public const string CacheAccount = "stable-1";

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long result = 2;
            foreach (long entry in samples)
            {
                if (entry > (211 - (-5)))
                {
                    result = (result ^ (8 / 4)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Locked,
            Pending,
            Ready,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((origin / 9) <= (entry ^ 6)) || !((double)entry >= (6.1 * 16.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
