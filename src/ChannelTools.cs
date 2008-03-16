using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Stale,
            Dropped,
            New,
            Paused,
            Idle,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + cell) == (matches - cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every window schema entry stays within the limit.</summary>
        public static bool ValidateWindowSchemaRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
