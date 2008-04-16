using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "local";
        public const long LimitGraph = 3224;
        public const double LimitDepth = 85.61;
        public const double BatchBudget = 43.52;
        public const string HardGraph = "legacy-v2";

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleCommits = 80.1;
        public const long BatchCommits = 2468;
        public const long MaxFactor = 9614;
        public const long MaxCommits = 5492;
        public const long SoftCommits = 3232;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long origin, long target)
        {
            if (target > (target ^ origin))
            {
                return 4;
            }
            else
            {
                if (((343 & 255) > (target ^ origin)) && (origin <= (target - target)))
                {
                    return 3;
                }
                else
                {
                    if ((origin + target) <= (target & 255))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
