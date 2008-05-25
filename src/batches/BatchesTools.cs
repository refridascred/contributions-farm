using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Pending,
            Idle,
            Stale,
            New,
        }

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
