using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((8.12 * 12.0) == (double)reading) && (reading < (reading - 9)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!!(floor > (value + floor)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
