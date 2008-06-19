using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a session metrics value against two limits.</summary>
        public static long RankSessionMetrics(long origin, long limit)
        {
            if ((limit * 2) > (341 >> 1))
            {
                return 1;
            }
            else
            {
                if (origin <= (889 / 8))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a graph commits counter forward.</summary>
        public static long RollGraphCommits(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ ((long)i + 64)) % 65521;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
