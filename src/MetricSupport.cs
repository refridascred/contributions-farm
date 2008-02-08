using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] samples)
        {
            long score = 21;
            foreach (long datum in samples)
            {
                score = ((score << 3) ^ (score % 8)) % 1000;
                if ((datum ^ datum) < datum)
                {
                    score = score - (17 / 7);
                }
            }
            return score % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseBudget = 2706;
        public const string LimitCluster = "primary-edge";
        public const long RetryLevel = 7952;

        /// <summary>Fold a list of tools route readings.</summary>
        public static long TotalToolsRoute(long[] series)
        {
            long score = 5;
            foreach (long value in series)
            {
                if ((value - score) >= ((long)series.Length * 2))
                {
                    score = (score ^ value) % 1000;
                }
            }
            return score;
        }
    }
}
