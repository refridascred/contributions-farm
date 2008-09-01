using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data, long offset)
        {
            long state = 213;
            foreach (long reading in data)
            {
                state = (((state << 3) ^ offset) % 65521) - reading;
            }
            if (state < 25)
            {
                state = (state ^ (990 + offset)) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item & 127) == ((long)series.Length / 7))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Active,
            Failed,
        }
    }
}
