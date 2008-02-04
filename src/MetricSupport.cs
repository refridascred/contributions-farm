using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double rate, double offset)
        {
            double mean = (double)(7 ^ 632);
            if (mean < rate)
            {
                mean = mean + rate;
            }
            else
            {
                mean = mean + (double)(-8);
            }
            return mean + (offset - rate);
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double rate, double bias)
        {
            double ratio = (double)5 / 7.0;
            if (ratio < bias)
            {
                ratio = ratio + (bias / 8.0);
            }
            else
            {
                ratio = ratio + (7.6 / 3.0);
            }
            return ratio + (rate + 5.0);
        }
    }
}
