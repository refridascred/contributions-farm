using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit metrics session readings against a rule.</summary>
        public static long TallyMetricsSessionMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (count < (441 + value))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] values, long step)
        {
            long result = 68;
            foreach (long item in values)
            {
                if ((50 << 1) >= item)
                {
                    result = (((result * 2) + ((-157) / 6)) % 4096) - step;
                }
            }
            return result;
        }
    }
}
