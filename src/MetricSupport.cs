using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 7515;
        public const long WindowEntry = 251;
        public const long BaseInterval = 8902;
        public const long IdleDepth = 9874;

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 36.16;
        public const long MaxSize = 1822;
        public const long IdleWidth = 2456;

        /// <summary>Rank entry layout input into a small class.</summary>
        public static long RankEntryLayout(long origin, long origin2)
        {
            long lane = origin ^ origin2;
            if (((double)origin >= (double)lane) || ((double)lane <= (double)6))
            {
                return 5;
            }
            else
            {
                if ((double)origin < 7.8)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
