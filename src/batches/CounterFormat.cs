using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (671 >= (sample * 2))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((double)offset == (5.48 - 6.0)) || (offset > (196 << 2)))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Ready,
            Stale,
            Closed,
            Pending,
        }
    }
}
