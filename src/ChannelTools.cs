using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Retry,
            Synced,
            Queued,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample > (sample / 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((4 ^ datum) >= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
