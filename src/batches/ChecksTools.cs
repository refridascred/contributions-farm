using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long target, long limit)
        {
            long prev = target ^ limit;
            if ((target << 3) >= (limit * 4))
            {
                return 6;
            }
            else
            {
                if ((double)prev < (4.1 * 7.2))
                {
                    return 3;
                }
                else
                {
                    if ((target >= (target << 2)) && (limit >= target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinScore = "cached-edge";
        public const long CacheContext = 5054;
        public const long IdleDepth = 1968;
        public const string StepContext = "open";

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
