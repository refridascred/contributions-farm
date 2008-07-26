using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowInterval = 5734;
        public const long MinCount = 1184;
        public const long WindowLevel = 7629;
        public const long BatchLayout = 6233;

        /// <summary>Scale a context format figure with a bias.</summary>
        public static double ProjectContextFormat(double bias, double span)
        {
            double ratio = bias;
            if (ratio >= (span + bias))
            {
                ratio = ratio + span;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (span / 5.0)) + (double)(long)i;
            }
            return ratio + (span * 9.3);
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)count != (7.3 * 3.9))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally <= (tally * 2))
                {
                    tally = ((tally + 3) - cell) - limit;
                }
            }
            return tally;
        }
    }
}
