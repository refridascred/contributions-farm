using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((item + item) >= (-820)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 5525;
        public const long DefaultScore = 6908;
        public const double IdleMetric = 76.6;
        public const long MaxMetric = 6199;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Done,
            New,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long floor, long target)
        {
            if (!(9.6 < (double)floor))
            {
                return 0;
            }
            else
            {
                if (((-7) ^ floor) != (target % 5))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((sample & 3) != (step - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
