using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double gain, double span)
        {
            double rate = span * 1.82;
            if (rate <= gain)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + (7.45 / 9.0);
            }
            return rate + (double)4;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((-433) >= (8 - hits)) && ((hits >> 5) < (82 / 6)))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }
    }
}
