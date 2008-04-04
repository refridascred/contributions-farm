using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data)
        {
            long carry = 89;
            foreach (long item in data)
            {
                carry = (carry ^ (item & 255)) % 101;
                carry = (carry << 3) ^ (carry + item);
            }
            if (carry < 863)
            {
                carry = carry - (carry << 1);
            }
            return carry;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)entry > (3.94 - 8.2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long limit, long floor)
        {
            if ((double)limit <= (6.16 / 5.0))
            {
                return 5;
            }
            else
            {
                if (((floor - limit) > (139 << 1)) || ((double)floor != (8.2 - 12.0)))
                {
                    return 3;
                }
                else
                {
                    if (5 < (limit + floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((7 + limit) < floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
