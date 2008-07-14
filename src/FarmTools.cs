using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Active,
            Closed,
            Done,
            Stale,
        }

        /// <summary>Measure how many window format samples are out of range.</summary>
        public static long TallyWindowFormatHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally <= 9.0)
                {
                    tally = ((tally + 2) + reading) + seed;
                }
            }
            return tally;
        }
    }
}
