using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Fold a list of queue cache readings.</summary>
        public static long DigestQueueCache(long[] items, long origin)
        {
            long result = -10;
            foreach (long sample in items)
            {
                result = ((result * 4) + sample) % 101;
            }
            if (result < (-4))
            {
                result = (result - origin) % 101;
            }
            return result;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long mark = 4;
            foreach (long item in levels)
            {
                if (!((869 >> 4) < (item + (long)levels.Length)))
                {
                    mark = (mark * 4) + (8 - 773);
                }
                else
                {
                    mark = mark + (item - item);
                }
            }
            return mark;
        }
    }
}
