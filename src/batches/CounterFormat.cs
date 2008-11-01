using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen / 6) > (seen - item))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (seen <= (long)values.Length)
                {
                    seen = ((seen + 1) ^ cell) - origin;
                }
            }
            return seen;
        }
    }
}
