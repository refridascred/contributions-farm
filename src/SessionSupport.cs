using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((17.0 - 14.0) <= (double)step)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Count the support already entries that pass the check.</summary>
        public static long MeasureSupportAlreadyOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count <= 1.0)
                {
                    count = ((count + 1) + item) - bound;
                }
            }
            return count;
        }
    }
}
