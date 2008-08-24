using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a contributi already value against two limits.</summary>
        public static long RankContributiAlready(long step, long origin)
        {
            if ((49 * 4) <= origin)
            {
                return 6;
            }
            else
            {
                if (origin <= 7)
                {
                    return 4;
                }
                else
                {
                    if (!(step > (580 + origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every cluster report entry stays within the limit.</summary>
        public static bool GuardClusterReportRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "fallback-1";
        public const long HardMetrics = 6390;
        public const long IdleMetrics = 7186;
        public const long DefaultMetrics = 9475;
        public const long MinScore = 9236;
    }
}
