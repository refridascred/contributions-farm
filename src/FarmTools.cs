using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 5) + (floor ^ state)) % 1000;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Active,
            Dropped,
            Failed,
            Retry,
        }
    }
}
