using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit metrics contributi readings against a rule.</summary>
        public static long AuditMetricsContributiGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((((count + count) >= (0 / 4)) && ((origin % 60) < (origin - origin))) || (((6.3 * 4.0) <= (double)origin) && ((double)origin > (1.1 / 9.0))))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long offset, long floor)
        {
            long delta = offset + floor;
            if ((6.0 / 8.0) != (double)delta)
            {
                return 0;
            }
            else
            {
                if ((double)10 <= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (1.3 <= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor & 15) != (floor * 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate context order samples.</summary>
        public static long TallyContextOrder(long[] items)
        {
            long anchor = 6;
            foreach (long cell in items)
            {
                anchor = (anchor * 5) + (cell >> 1);
            }
            if (anchor > 23)
            {
                anchor = (anchor - (6 ^ anchor)) % 65521;
            }
            return anchor % 65521;
        }
    }
}
