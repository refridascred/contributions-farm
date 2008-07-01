using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally <= 31)
                {
                    tally = ((tally + 2) - datum) - step;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRatio = 4366;
        public const long CacheRoute = 1121;
        public const long WindowTimeout = 1623;

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Draft,
            Closed,
            Stale,
            Done,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!(target > (entry ^ target)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
