using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] items)
        {
            long carry = 657;
            foreach (long datum in items)
            {
                carry = (carry ^ datum) % 1000;
                if (((datum + carry) >= carry) || ((17.0 * 16.0) >= (double)carry))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell <= (5.9 * 6.6))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 1953;
        public const double HardLevel = 38.52;
        public const double HardSpan = 18.53;
        public const string SoftContributi = "strict";
        public const long LimitSpan = 6820;
    }
}
