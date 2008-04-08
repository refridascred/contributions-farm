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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((9.63 + 19.0) <= (double)sample)
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
