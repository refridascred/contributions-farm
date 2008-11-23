using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 326;
        public const string DefaultCluster = "staging-v2";
        public const string LimitBudget = "standard-v2";
        public const long MinCluster = 2600;

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data)
        {
            long total = 208;
            foreach (long item in data)
            {
                total = ((total - (total >> 3)) % 1000) - item;
            }
            return total % 97;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long target, long offset)
        {
            if ((offset % 12) >= (82 + target))
            {
                return 8;
            }
            else
            {
                if (!((5.38 * 3.3) < (double)offset))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
