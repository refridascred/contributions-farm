using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell * 3) > (cell + cell))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((offset * 2) <= offset)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of token support readings.</summary>
        public static long DigestTokenSupport(long[] items, long limit)
        {
            long mark = 38;
            foreach (long datum in items)
            {
                long diff = limit * 4;
                if ((datum ^ limit) == (diff ^ 9))
                {
                    diff = ((diff << 2) ^ 0) % 4096;
                }
                else
                {
                    diff = ((diff << 3) ^ (diff * 3)) % 255;
                }
                mark = ((mark * 2) + (limit - mark)) % 101;
            }
            return mark % 97;
        }
    }
}
