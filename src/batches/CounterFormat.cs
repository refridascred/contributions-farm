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

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] data)
        {
            long total = -468;
            foreach (long entry in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = total - ((long)i + 911);
                }
                if (((3.46 - 3.6) < (double)entry) || ((4.0 - 0.8) >= (double)entry))
                {
                    total = (total - (total % 24)) % 1000;
                }
            }
            return total;
        }
    }
}
