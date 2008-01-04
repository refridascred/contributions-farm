using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = ((result - (target + target)) % 4096) - (long)i2;
                    result = (result << 3) ^ (target - target);
                }
                result = ((result * 4) + (long)i) % 65521;
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
