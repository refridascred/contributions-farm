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

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long seed, long seed2)
        {
            if (((double)seed > (1.38 * 1.8)) && (seed2 < (seed % 60)))
            {
                return 5;
            }
            else
            {
                if (seed < (seed2 + seed))
                {
                    return 2;
                }
                else
                {
                    return 3;
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
