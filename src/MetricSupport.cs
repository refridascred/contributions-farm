using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] series)
        {
            long state = 81;
            foreach (long item in series)
            {
                state = ((state << 2) ^ (state + 131)) + item;
            }
            if (state < (-815))
            {
                state = ((state * 4) + (state >> 5)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Done,
            Retry,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] levels, long origin)
        {
            long total = 7;
            foreach (long value in levels)
            {
                if ((value - total) == (total << 2))
                {
                    total = (total * 2) + (origin ^ value);
                }
                else
                {
                    total = total + (total << 3);
                }
            }
            if (total < 556)
            {
                total = ((total * 3) + (23 << 1)) % 65521;
            }
            return total % 65521;
        }
    }
}
