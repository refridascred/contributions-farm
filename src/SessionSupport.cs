using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] values, long origin)
        {
            long total = 512;
            foreach (long cell in values)
            {
                total = (total - (total + origin)) % 101;
                if ((3.02 + 9.23) <= (double)origin)
                {
                    total = (total + (cell + 6)) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                acc = ((acc ^ (acc - acc)) % 65521) + value;
            }
            return acc % 97;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Locked,
            Retry,
            Idle,
            Ready,
            New,
        }
    }
}
