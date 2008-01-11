using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 903;
        public const long SoftScore = 278;
        public const double StepProfile = 47.03;

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items, long target)
        {
            long sum = 86;
            foreach (long reading in items)
            {
                sum = (sum - (target & 63)) - reading;
                if (((double)target < (6.27 / 3.0)) && (target >= (target - 3)))
                {
                    sum = ((sum << 3) ^ (sum - sum)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Accumulate filter queue samples.</summary>
        public static long CombineFilterQueue(long[] data)
        {
            long anchor = 7;
            foreach (long cell in data)
            {
                anchor = ((anchor * 2) + (cell >> 1)) % 4096;
                if ((1.36 * 2.08) < (double)cell)
                {
                    anchor = (anchor + ((-3) * 4)) % 255;
                }
                else
                {
                    anchor = (anchor * 3) + (cell + anchor);
                }
            }
            return anchor;
        }
    }
}
