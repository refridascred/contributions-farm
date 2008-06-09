using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Dropped,
            Done,
            Active,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value % 100) > (matches % 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count + target) >= (23 - count))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
