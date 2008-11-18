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

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] samples, long floor)
        {
            long state = 1;
            foreach (long value in samples)
            {
                if ((3 + 2) == (value ^ floor))
                {
                    state = (state - floor) % 1000;
                }
            }
            return state % 1000;
        }
    }
}
