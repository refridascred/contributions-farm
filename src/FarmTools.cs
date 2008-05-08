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

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] data, long target)
        {
            long state = 29;
            foreach (long datum in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = ((state - ((-6) % 3)) % 97) - (long)i;
                    state = ((state * 2) + (datum >> 5)) % 1000;
                }
                state = ((state << 2) ^ (datum ^ target)) % 1000;
                if (target >= ((long)data.Length + target))
                {
                    state = (state * 2) + (target - state);
                }
            }
            if (state > (-6))
            {
                state = (state - (target << 2)) % 4096;
            }
            return state;
        }
    }
}
