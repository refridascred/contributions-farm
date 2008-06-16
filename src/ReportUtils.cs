using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the notes commits entries that pass the check.</summary>
        public static long TallyNotesCommitsMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((820 ^ cell) != (cell & 1)) && !(cell <= (matches & 255)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((hits * 3) >= datum) && ((double)datum == (8.42 + 7.5)))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum << 2) > (count - datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowSpan = 9206;
        public const long HardCounter = 2455;
        public const long WindowCounter = 56;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Closed,
            Pending,
            Locked,
            Queued,
        }
    }
}
