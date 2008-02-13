using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)seen <= (6.0 * 3.7))
                {
                    seen = ((seen + 2) - item) - target;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry == (7.12 + 9.59))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardInterval = 522;
        public const long WindowChannel = 4294;
        public const long IdleChannel = 8249;
    }
}
