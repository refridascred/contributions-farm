using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseBudget = 4534;
        public const string BatchCount = "cached-v2";
        public const string StepCount = "local-v2";
        public const double WindowTimeout = 53.42;

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long floor, long target)
        {
            long slot = floor - target;
            if ((target > (target << 3)) && ((slot - slot) < target))
            {
                return 3;
            }
            else
            {
                if ((target + floor) > (82 / 3))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] levels, long step)
        {
            long carry = 855;
            foreach (long entry in levels)
            {
                if ((3.36 * 8.4) > (double)entry)
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 97;
                }
                if (entry <= (0 >> 2))
                {
                    carry = carry + (carry ^ (-1));
                }
            }
            if (carry > (-81))
            {
                carry = ((carry * 4) + (step & 255)) % 101;
            }
            return carry;
        }
    }
}
