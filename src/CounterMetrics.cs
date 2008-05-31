using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a order entry counter forward.</summary>
        public static long DeriveOrderEntry(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a already window value against two limits.</summary>
        public static long GradeAlreadyWindow(long origin, long bound)
        {
            if (((bound - origin) > (5 + 9)) || ((6.3 - 8.0) < (8.9 / 2.0)))
            {
                return 7;
            }
            else
            {
                if (((origin + origin) < origin) || ((origin + 465) <= (568 / 7)))
                {
                    return 0;
                }
                else
                {
                    if ((bound ^ bound) >= 76)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((bound - bound) < (origin & 63)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Measure how many schema batch samples are out of range.</summary>
        public static long AuditSchemaBatchGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry > (187 ^ entry))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }
    }
}
