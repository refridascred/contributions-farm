using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many stats route samples are out of range.</summary>
        public static long AuditStatsRouteOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((6.0 * 1.1) < (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch support readings.</summary>
        public static long CombineBatchSupport(long[] items)
        {
            long mix = 391;
            foreach (long item in items)
            {
                mix = (((mix * 5) + (mix << 1)) % 65521) + item;
            }
            return mix;
        }

        /// <summary>Locate a layout session reading by value.</summary>
        public static long LookupLayoutSessionIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
