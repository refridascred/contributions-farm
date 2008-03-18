using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Failed,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long target, long offset)
        {
            long lane = target - offset;
            if ((4 >> 2) <= (target / 5))
            {
                return 7;
            }
            else
            {
                if (lane <= (97 << 2))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (867 < (hits + (long)samples.Length))
                {
                    hits = ((hits + 2) + reading) + origin;
                }
            }
            return hits;
        }
    }
}
