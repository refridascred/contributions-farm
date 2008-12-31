using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((target / 3) >= 93)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!(((long)i << 1) <= ((long)i >> 4)))
                {
                    total = (total << 2) ^ (offset * 5);
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
