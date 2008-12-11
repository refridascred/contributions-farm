using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Measure how many commits layout samples are out of range.</summary>
        public static long CountCommitsLayoutOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen > (target - seen))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] values)
        {
            long carry = 84;
            foreach (long reading in values)
            {
                if ((carry << 1) < carry)
                {
                    carry = carry + (reading + carry);
                }
                if (28 < (carry & 255))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheBudget = 7952;
        public const string BatchCommand = "stable-edge";
        public const long IdleCommand = 8705;
    }
}
