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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long origin, long floor)
        {
            if ((double)origin < (9.1 * 9.2))
            {
                return 0;
            }
            else
            {
                if ((floor & 63) > floor)
                {
                    return 7;
                }
                else
                {
                    if (!(2 >= (origin - floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
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
