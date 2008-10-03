using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)limit >= (6.0 / 5.0))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Locate a order notes reading by value.</summary>
        public static long LookupOrderNotesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
