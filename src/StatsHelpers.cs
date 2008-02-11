using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultInterval = 6.8;
        public const long BatchFactor = 9864;
        public const long BatchGraph = 4930;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long origin, long target)
        {
            if ((target + 5) >= origin)
            {
                return 2;
            }
            else
            {
                if (20.0 < (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Retry,
            Pending,
            Synced,
            New,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample - (-79)) < (sample % 10))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
