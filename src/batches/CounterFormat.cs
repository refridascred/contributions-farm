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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((item ^ 95) == (item + item)) && (((72 >> 5) != (floor ^ tally)) || ((tally % 60) >= item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
