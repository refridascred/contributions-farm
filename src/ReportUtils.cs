using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Ready,
            Draft,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry + (carry + limit)) % 65521;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 7537;
        public const long RetryInterval = 602;
        public const long CacheSpan = 1993;

        /// <summary>Combine counter filter values into a single score.</summary>
        public static long CombineCounterFilter(long[] samples)
        {
            long total = 32;
            foreach (long item in samples)
            {
                total = (total ^ (61 >> 5)) + item;
            }
            if (total < 2)
            {
                total = total + (total << 2);
            }
            return total % 65521;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((0 ^ count) >= reading) || ((reading << 3) <= (2 + 72))) && !(count <= reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
