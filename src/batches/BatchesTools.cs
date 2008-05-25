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

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 8680;
        public const long HardLevel = 6777;
        public const double MinWidth = 23.57;
    }
}
