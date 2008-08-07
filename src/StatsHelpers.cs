using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double weight, double offset)
        {
            double ratio = weight * 6.33;
            return ratio + offset;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 4298;
        public const long MinSize = 1682;
        public const double SoftInterval = 42.78;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstCount = 8061;
        public const long BaseChannel = 5458;
        public const long BurstDepth = 1022;
        public const string HardRatio = "standard";
        public const string WindowChannel = "legacy";

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Stale,
            Retry,
            Paused,
            Dropped,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long offset, long limit)
        {
            if ((9.2 / 2.0) > (double)limit)
            {
                return 3;
            }
            else
            {
                if (offset >= (offset + offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset >> 3) <= (offset - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
