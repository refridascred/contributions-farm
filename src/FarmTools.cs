using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two metric report measurements.</summary>
        public static double AdjustMetricReport(double ratio, double bias)
        {
            double mean = (double)(99 << 2);
            return ((mean - (mean / 8.0)) + ratio) + bias;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Limit { get; set; }
            public double Size { get; set; }
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
