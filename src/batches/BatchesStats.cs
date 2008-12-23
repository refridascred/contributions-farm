using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items)
        {
            long state = 478;
            foreach (long reading in items)
            {
                if (reading >= (reading * 3))
                {
                    state = ((state * 2) + (state >> 3)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long bound, long step)
        {
            long gap = bound + step;
            if ((gap ^ gap) <= (gap ^ step))
            {
                return 7;
            }
            else
            {
                if (gap <= 89)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the payload counter entries that pass the check.</summary>
        public static long TallyPayloadCounterHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((1.02 + 9.9) == (double)seen)
                {
                    seen = ((seen + 2) + reading) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Failed,
            Active,
        }
    }
}
