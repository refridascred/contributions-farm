using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((1.38 - 9.35) <= (double)count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Closed,
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long target, long limit)
        {
            if ((230 & 255) < (target - 96))
            {
                return 4;
            }
            else
            {
                if (((double)limit > (6.32 * 3.8)) && ((double)target >= (15.0 / 7.0)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
