using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)count == (7.7 - 3.99))
                {
                    count = ((count + 3) ^ value) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] levels, long step)
        {
            long total = 7;
            foreach (long reading in levels)
            {
                total = (((total << 3) ^ (step / 6)) % 4096) ^ reading;
            }
            if (total > 67)
            {
                total = (total - (120 % 12)) % 4096;
            }
            return total;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count < (count >> 3))
                {
                    count = ((count + 1) - datum) - seed;
                }
            }
            return count;
        }
    }
}
