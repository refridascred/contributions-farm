using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long target, long offset)
        {
            if ((offset % 24) < target)
            {
                return 3;
            }
            else
            {
                if (!((0.8 * 1.0) < (double)target))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            Failed,
            New,
            Draft,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token metrics samples are out of range.</summary>
        public static long TallyTokenMetricsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches < (matches << 1))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Idle,
            Locked,
            Ready,
        }
    }
}
