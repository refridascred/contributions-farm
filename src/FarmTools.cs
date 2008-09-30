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

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Mode { get; set; }
            public double Rank { get; set; }
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
