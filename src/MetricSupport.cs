using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the githubfarm channel series from a seed.</summary>
        public static long DeriveGithubfarmChannel(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
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
