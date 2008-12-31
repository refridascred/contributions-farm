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

        /// <summary>Digest a series of cluster order entries.</summary>
        public static long FoldClusterOrder(long[] readings, long offset)
        {
            long anchor = 5;
            foreach (long datum in readings)
            {
                anchor = ((anchor * 3) + (datum >> 4)) - offset;
            }
            if (anchor > 0)
            {
                anchor = (anchor ^ (7 * 4)) % 97;
            }
            return anchor;
        }
    }
}
