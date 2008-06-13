using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (reading < (matches * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Failed,
            Paused,
            Synced,
            Done,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
