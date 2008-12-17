using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long offset, long seed)
        {
            long lane = offset - seed;
            if (((seed / 2) <= offset) || ((seed + (-72)) == (seed >> 1)))
            {
                return 2;
            }
            else
            {
                if ((lane + 824) > (seed * 2))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 51.18;
        public const long IdleBudget = 6257;
        public const long LimitChecks = 4099;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            Ready,
            Pending,
            Active,
            Done,
        }
    }
}
