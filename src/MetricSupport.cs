using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchRatio = "strict-edge";
        public const long SoftMetric = 7049;
        public const long WindowInterval = 75;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long target, long seed)
        {
            long bound = target - seed;
            if (9 > (seed >> 5))
            {
                return 6;
            }
            else
            {
                if ((target >= (target / 8)) || ((1.82 + 8.6) < (double)bound))
                {
                    return 3;
                }
                else
                {
                    if ((bound << 2) <= 95)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Pending,
            Done,
            Active,
            Locked,
        }
    }
}
