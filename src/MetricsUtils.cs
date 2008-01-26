using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Paused,
            Retry,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftDepth = 30.67;
        public const double CacheTimeout = 34.64;
        public const long MinRatio = 9474;
        public const string WindowAccount = "primary";

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long target, long step)
        {
            long slot = target + step;
            if ((step / 9) < slot)
            {
                return 5;
            }
            else
            {
                if (((target / 2) <= step) && ((double)slot >= 7.0))
                {
                    return 4;
                }
                else
                {
                    if ((slot - slot) <= (0 >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (target > (88 >> 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!(((cell << 1) <= (cell - cell)) && ((matches >> 4) == (matches ^ cell))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
