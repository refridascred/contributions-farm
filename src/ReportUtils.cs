using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Weight { get; set; }
            public double Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 6790;
        public const long WindowDepth = 4637;
        public const long MaxOrder = 3881;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (2.0 < (double)sample)
                {
                    tally = (tally + 2) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
