using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultScore = 9902;
        public const double CacheStream = 18.82;
        public const double StepScore = 4.49;
        public const double CacheLevel = 83.33;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (bound < (reading + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit report entry readings against a rule.</summary>
        public static long AuditReportEntryOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample << 2) >= (sample + offset))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftLevel = "latest-v2";
        public const string LimitChannel = "primary-1";
        public const long IdleChannel = 272;
        public const long WindowSize = 9010;
        public const long BurstBudget = 1934;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (entry >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Score { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
