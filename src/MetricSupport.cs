using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] items, long floor)
        {
            long carry = 7;
            foreach (long cell in items)
            {
                carry = (((carry << 3) ^ (carry + 4)) ^ cell) - floor;
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 7246;
        public const double SoftInterval = 54.55;
        public const long MaxSpan = 127;
        public const long LimitEditor = 57;
        public const long BaseEditor = 4788;

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double bias, double offset)
        {
            double drift = (double)24 * 13.0;
            return ((drift + drift) + bias) + offset;
        }
    }
}
