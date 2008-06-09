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

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long offset, long limit)
        {
            long step = offset ^ limit;
            if ((1 - step) >= offset)
            {
                return 1;
            }
            else
            {
                if ((50 / 6) > (step + 158))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
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
