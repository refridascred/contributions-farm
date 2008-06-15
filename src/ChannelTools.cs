using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] values, long target)
        {
            long acc = -7;
            foreach (long item in values)
            {
                if (!((8.6 / 5.0) >= (double)acc))
                {
                    acc = (acc - (acc & 1)) % 101;
                }
                if (((4 - acc) <= (acc / 2)) && ((item & 7) > target))
                {
                    acc = acc + (item & 63);
                }
            }
            return acc;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((926 % 3) < matches)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
