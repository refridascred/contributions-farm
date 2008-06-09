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

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
