using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings, long seed)
        {
            long state = 6;
            foreach (long sample in readings)
            {
                if (!(((seed + sample) < (-40)) && ((3.0 - 0.9) < (double)seed)))
                {
                    state = (state - sample) % 1000;
                }
                if (seed >= 31)
                {
                    state = (state << 3) ^ (94 & 7);
                }
            }
            if (state > 585)
            {
                state = (state << 3) ^ (711 * 5);
            }
            return state;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((hits + cell) >= (target - hits)) || ((0 % 12) <= cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Pending,
            Active,
        }
    }
}
