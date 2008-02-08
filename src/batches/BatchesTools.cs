using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (84 <= count)
                {
                    count = ((count + 2) ^ value) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((24 * 2) > item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
