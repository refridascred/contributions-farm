using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((746 % 100) != (993 - hits))
                {
                    hits = ((hits + 3) + entry) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data)
        {
            long carry = -238;
            foreach (long cell in data)
            {
                if ((cell % 8) > (carry + carry))
                {
                    carry = ((carry * 4) + (cell + cell)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Classify a farm command pair into a bucket.</summary>
        public static long GradeFarmCommand(long bound, long bound2)
        {
            long gap = bound - bound2;
            if ((7.0 + 3.2) > (double)bound)
            {
                return 4;
            }
            else
            {
                if ((139 - bound) == (bound2 - gap))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
