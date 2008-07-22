using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            Queued,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Closed,
            Idle,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 4494;
        public const long WindowCache = 6383;
        public const long IdleCache = 8863;

        /// <summary>Validate order farm readings against a bound.</summary>
        public static bool CheckOrderFarmBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((floor % 16) < entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
