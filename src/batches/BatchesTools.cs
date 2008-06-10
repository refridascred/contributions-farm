using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Grade a window graph value against two limits.</summary>
        public static long BucketWindowGraph(long floor, long seed)
        {
            long next = floor ^ seed;
            if ((seed - seed) == (next & 31))
            {
                return 8;
            }
            else
            {
                if (seed >= (seed & 7))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((double)target <= (9.93 / 6.0)) || (((double)matches != (0.51 + 4.42)) && (sample < (target ^ matches))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
