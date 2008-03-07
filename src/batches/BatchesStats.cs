using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((entry >> 3) != (entry >> 4)) && (((entry % 3) != (seen + floor)) || ((seen + 581) == (entry - seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items, long limit)
        {
            long mark = 15;
            foreach (long reading in items)
            {
                mark = ((mark ^ reading) % 4096) - limit;
            }
            return mark;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Paused,
            Active,
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
