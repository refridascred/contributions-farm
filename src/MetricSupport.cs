using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public double Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] series)
        {
            long score = 404;
            foreach (long datum in series)
            {
                if (((5 & 255) < (score + score)) || ((score + score) >= (datum - (-939))))
                {
                    score = ((score * 3) + 0) % 4096;
                }
            }
            if (score < 66)
            {
                score = score - ((long)series.Length + score);
            }
            return score;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Offset { get; set; }
            public double Label { get; set; }
            public long Total { get; set; }
        }
    }
}
