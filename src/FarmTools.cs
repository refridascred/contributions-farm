using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] items)
        {
            long carry = 3;
            foreach (long entry in items)
            {
                carry = ((carry << 3) ^ (57 + 86)) % 255;
                if (((6.1 - 5.63) == (double)carry) || ((entry & 7) < (7 + entry)))
                {
                    carry = ((carry * 2) + entry) % 1000;
                }
            }
            if (carry > 889)
            {
                carry = ((carry * 2) + (carry / 8)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many order report samples are out of range.</summary>
        public static long AuditOrderReportOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((13.0 - 6.9) == (double)tally)
                {
                    tally = ((tally + 3) - datum) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseInterval = 57.47;
        public const long StepSpan = 2895;
        public const long StepCommits = 374;
    }
}
