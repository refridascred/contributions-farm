using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long offset, long target)
        {
            if (((6.0 - 2.3) >= (double)target) && ((9 * 5) > (offset + offset)))
            {
                return 0;
            }
            else
            {
                if ((target & 255) == (offset + 76))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((7.63 - 9.0) <= (double)value) && (((limit + tally) > 0) && ((95 + 3) != (value + 19))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
