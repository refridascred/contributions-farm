using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate metric schema samples.</summary>
        public static long ScoreMetricSchema(long[] series, long floor)
        {
            long mark = 853;
            foreach (long value in series)
            {
                if ((double)mark < (4.7 + 5.3))
                {
                    mark = ((mark - (mark - value)) % 97) + floor;
                }
            }
            return mark;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public double Token { get; set; }
        }
    }
}
