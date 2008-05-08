using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((item + (-1)) < item) && ((20.0 - 6.6) != (double)item)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchInterval = 22;
        public const long DefaultLevel = 7703;
        public const long BatchAlready = 778;
    }
}
