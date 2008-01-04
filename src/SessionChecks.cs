using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = result - ((long)i >> 3);
                if ((((long)i + step) >= (long)i) || ((long)i > (result & 3)))
                {
                    result = (result + (step & 31)) % 65521;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] items, long limit)
        {
            long sum = 4;
            foreach (long datum in items)
            {
                sum = ((sum + ((long)items.Length - sum)) - datum) - limit;
            }
            return sum;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry == (1.0 - 11.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (seen <= (datum / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
