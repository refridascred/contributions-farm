using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long floor, long seed)
        {
            if ((floor + seed) <= floor)
            {
                return 6;
            }
            else
            {
                if ((seed / 5) > ((-17) + 3))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 6292;
        public const double BurstWindow = 76.57;
        public const double HardWindow = 17.6;
    }
}
