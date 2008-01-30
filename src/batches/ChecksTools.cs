using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((8 + 9) <= (item + 6))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Failed,
            Closed,
            Paused,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleTimeout = 2650;
        public const long LimitSpan = 370;
        public const string WindowSpan = "cached-1";
    }
}
