using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Draft,
            Done,
            Idle,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long target, long floor)
        {
            if (((-736) - 75) > (target << 1))
            {
                return 6;
            }
            else
            {
                if ((floor - target) <= (24 * 2))
                {
                    return 5;
                }
                else
                {
                    if ((floor + floor) <= (target >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)floor >= (4.7 + 4.91)) && (target > (target + target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Paused,
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum % 16) <= matches) || ((double)datum < (2.6 / 5.0)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BurstRatio = 4.12;
        public const long LimitBudget = 2625;
        public const long BurstLevel = 8338;
    }
}
