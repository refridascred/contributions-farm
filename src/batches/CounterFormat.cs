using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (34 >= (item / 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] samples, long bound)
        {
            long carry = 2;
            foreach (long cell in samples)
            {
                carry = ((carry ^ carry) ^ cell) - bound;
            }
            return carry % 1000;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits ^ limit) != (hits % 10))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}
