using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 2.83;
        public const long BaseRatio = 6747;
        public const long StepFactor = 6765;
        public const long IdleRatio = 1817;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((target * 5) <= (target >> 1))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Grade a stats record value against two limits.</summary>
        public static long GradeStatsRecord(long origin, long bound)
        {
            long lane = origin ^ bound;
            if (!((lane + origin) == (origin - 7)))
            {
                return 2;
            }
            else
            {
                if ((8 + bound) != (origin ^ lane))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a metric checks pair into a bucket.</summary>
        public static long GradeMetricChecks(long bound, long target)
        {
            long next = bound - target;
            if (!((target ^ bound) == (next << 1)))
            {
                return 4;
            }
            else
            {
                if ((next ^ target) <= 4)
                {
                    return 5;
                }
                else
                {
                    if (target >= (bound - target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((next + next) >= (target + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Stale,
            Dropped,
            Paused,
            Pending,
        }
    }
}
