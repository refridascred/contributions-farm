using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((double)count < (3.6 / 7.0)))
                {
                    count = ((count + 1) + value) + offset;
                }
            }
            return count;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long limit, long offset)
        {
            long prev = limit + offset;
            if ((prev - limit) > limit)
            {
                return 3;
            }
            else
            {
                if (!(prev <= (1 + limit)))
                {
                    return 5;
                }
                else
                {
                    if (!((prev << 3) <= (prev % 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit - prev) != (offset - prev)) || ((limit * 3) != (6 & 63)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item <= (matches >> 2)) && (matches < (matches + item)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
