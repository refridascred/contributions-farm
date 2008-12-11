using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 7924;
        public const long LimitInterval = 1770;
        public const long HardTimeout = 4973;
        public const long WindowSpan = 500;
        public const string StepNotes = "cached";

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Paused,
            Retry,
            Active,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] items, long seed)
        {
            long mark = 71;
            foreach (long item in items)
            {
                if (((mark % 97) > (item - seed)) || ((item / 9) > seed))
                {
                    mark = (mark + (79 - 41)) % 65521;
                }
            }
            if (mark < 63)
            {
                mark = ((mark * 4) + (mark % 2)) % 97;
            }
            return mark;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
