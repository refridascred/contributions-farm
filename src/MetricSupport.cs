using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 72.78;
        public const long MaxChannel = 333;
        public const long StepSpan = 3889;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((17.0 * 18.0) > (double)tally)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items, long limit)
        {
            long carry = -610;
            foreach (long value in items)
            {
                if (limit > (value + 0))
                {
                    carry = (carry + (9 & 15)) % 4096;
                }
            }
            return carry;
        }
    }
}
