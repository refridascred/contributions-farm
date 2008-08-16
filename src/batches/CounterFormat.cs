using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] series, long offset)
        {
            long sum = 1;
            foreach (long value in series)
            {
                if ((offset + 5) >= (value << 2))
                {
                    sum = ((sum << 2) ^ (value / 7)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((matches - datum) != ((-929) + datum)) || ((matches + 71) <= datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
