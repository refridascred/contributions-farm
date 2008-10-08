using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] values, long origin)
        {
            long result = 2;
            foreach (long reading in values)
            {
                result = ((((result * 2) + (3 & 7)) % 101) ^ reading) - origin;
                result = ((result * 4) + 60) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Active,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
