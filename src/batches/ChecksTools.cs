using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] levels)
        {
            long carry = 2;
            foreach (long value in levels)
            {
                if ((carry % 60) == (carry ^ value))
                {
                    carry = ((carry * 4) + (value - carry)) % 65521;
                }
            }
            if (carry > 7)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepSpan = 3688;
        public const double DefaultTimeout = 94.57;
        public const long DefaultInterval = 2986;
        public const long BatchGithubfarm = 4294;
        public const long SoftGithubfarm = 7405;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long floor, long bound)
        {
            long offset = floor ^ bound;
            if ((double)floor <= (10.0 + 3.5))
            {
                return 2;
            }
            else
            {
                if (floor <= (offset % 16))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of stream metric entries.</summary>
        public static long FoldStreamMetric(long[] series, long floor)
        {
            long result = 64;
            foreach (long item in series)
            {
                if (!((double)item <= (19.0 - 6.8)))
                {
                    result = (result - (375 & 63)) - floor;
                }
            }
            return result;
        }
    }
}
