using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit metrics session readings against a rule.</summary>
        public static long CountMetricsSessionMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + count) < (3 ^ 69))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long origin, long target)
        {
            if (((3.7 * 20.0) != (double)origin) || ((double)133 >= (double)target))
            {
                return 6;
            }
            else
            {
                if (1 >= origin)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((tally + tally) <= datum) && ((tally & 255) > (tally % 100)))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}
