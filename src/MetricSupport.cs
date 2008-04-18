using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryCount = 1089;
        public const long DefaultChannel = 4283;
        public const long LimitChannel = 3593;
        public const long CacheChannel = 1647;
        public const string BurstChannel = "alpha";

        /// <summary>Measure how many githubfarm profile samples are out of range.</summary>
        public static long TallyGithubfarmProfileMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)datum < 4.0)
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Count githubfarm format pairs that satisfy a relation.</summary>
        public static long PairGithubfarmFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
