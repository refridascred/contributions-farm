using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                state = state - state;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long bound, long offset)
        {
            if (bound >= offset)
            {
                return 8;
            }
            else
            {
                if ((bound & 15) != (bound / 3))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
