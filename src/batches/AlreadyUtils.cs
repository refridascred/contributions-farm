using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((entry << 3) != (matches % 64)) && ((matches << 2) >= (712 * 5)))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Pending,
            Dropped,
            Paused,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((((hits + hits) > 6) && ((cell - hits) > ((long)values.Length % 2))) || ((double)hits < 5.1))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Dropped,
            Pending,
            Synced,
            Done,
            Stale,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
