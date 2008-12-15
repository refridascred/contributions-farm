using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Failed,
            New,
            Ready,
            Pending,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Stale,
            Active,
            Idle,
            New,
            Ready,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((double)value < 6.2) || !(4 >= (value ^ (long)items.Length)))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Count the format stream entries that pass the check.</summary>
        public static long MeasureFormatStreamMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((2.99 / 2.0) < (double)hits)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter account samples are out of range.</summary>
        public static long TallyCounterAccountHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + cell) == (count - 60))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
