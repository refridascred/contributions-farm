using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)629 > (double)hits)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 4521;
        public const string SoftWindow = "stable-v2";
        public const string CacheWindow = "cached";

        /// <summary>Rank command batches input into a small class.</summary>
        public static long GradeCommandBatches(long step, long bound)
        {
            long edge = step ^ bound;
            if (edge >= (edge & 63))
            {
                return 6;
            }
            else
            {
                if ((double)(-159) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)step == (double)edge)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "cached-1";
        public const string DefaultBudget = "legacy";
        public const double RetryContext = 50.42;
        public const long CacheContext = 4936;
    }
}
