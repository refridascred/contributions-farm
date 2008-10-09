using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long origin, long target)
        {
            if (4 < (origin ^ origin))
            {
                return 0;
            }
            else
            {
                if (((target >> 1) <= target) && ((7 << 2) == (origin - target)))
                {
                    return 4;
                }
                else
                {
                    if (!((target - target) > (origin / 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin - target) < (target - origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 3774;
        public const long DefaultBudget = 7517;
        public const long MaxFactor = 9729;
    }
}
