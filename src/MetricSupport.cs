using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double span)
        {
            double drift = (double)(997 & 1);
            if (drift <= (span * 13.0))
            {
                drift = (drift + (drift / 9.0)) + rate;
            }
            else
            {
                drift = drift - (double)4;
            }
            return drift - drift;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
        }
    }
}
