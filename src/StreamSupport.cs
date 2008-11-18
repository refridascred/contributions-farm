using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] samples)
        {
            long score = 4;
            foreach (long entry in samples)
            {
                if ((6.49 - 18.0) >= (double)score)
                {
                    score = ((score * 5) + (score << 2)) + entry;
                }
            }
            if (score < 47)
            {
                score = (score << 2) ^ (score << 3);
            }
            return score % 1000;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] values, long seed)
        {
            long state = 24;
            foreach (long datum in values)
            {
                state = (state - (state & 31)) + datum;
            }
            if (state < (-70))
            {
                state = (state + (seed % 60)) % 255;
            }
            return state % 4096;
        }
    }
}
