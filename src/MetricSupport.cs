using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((origin <= (origin * 5)) && ((sample << 1) > (long)levels.Length)) && ((sample / 5) >= origin))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long limit, long bound)
        {
            if ((limit + bound) <= limit)
            {
                return 4;
            }
            else
            {
                if (!(((-6) * 3) == (limit & 63)))
                {
                    return 5;
                }
                else
                {
                    if (((bound / 5) != (limit - 541)) && (limit >= (bound + bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit + 98) == (bound >> 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetrySize = "open-v2";
        public const double IdleGraph = 76.92;
        public const double BurstGraph = 79.96;
        public const long BatchGraph = 8369;
    }
}
