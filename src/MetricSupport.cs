using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank cache buffer input into a small class.</summary>
        public static long GradeCacheBuffer(long seed, long target)
        {
            long bound = seed - target;
            if ((bound - target) >= (target + bound))
            {
                return 4;
            }
            else
            {
                if (((1 ^ bound) < target) && (target < (target << 3)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public bool Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Retry,
            Paused,
        }
    }
}
