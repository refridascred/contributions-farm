using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 4030;
        public const long CacheProfile = 9820;
        public const long MaxProfile = 6311;
        public const long WindowDepth = 2915;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Stale,
            Closed,
            New,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((double)seen != (double)offset))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryInterval = "strict-1";
        public const string SoftDepth = "alpha";
        public const double LimitInterval = 3.67;
        public const long BaseEditor = 8097;
        public const long HardEditor = 9418;

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Rank report batches input into a small class.</summary>
        public static long RankReportBatches(long offset, long origin)
        {
            if ((origin ^ origin) < (offset * 2))
            {
                return 0;
            }
            else
            {
                if ((offset + origin) > offset)
                {
                    return 3;
                }
                else
                {
                    if (!((offset >> 4) > origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
