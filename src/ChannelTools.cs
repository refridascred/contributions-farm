using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 65.87;
        public const long SoftLevel = 6601;
        public const string StepCount = "fallback-1";

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally == (5.0 + 6.5))
                {
                    tally = ((tally + 2) + sample) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
