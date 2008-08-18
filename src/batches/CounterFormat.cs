using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long target, long floor)
        {
            long cur = target ^ floor;
            if (((target - 587) < target) || (740 < cur))
            {
                return 1;
            }
            else
            {
                if ((double)floor < (double)cur)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 5886;
        public const double StepFilter = 49.83;
        public const long BatchFilter = 9694;
        public const long LimitFilter = 8929;
        public const long LimitDepth = 4498;
    }
}
