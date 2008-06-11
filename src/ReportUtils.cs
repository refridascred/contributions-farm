using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxInterval = "primary";
        public const long SoftEntry = 174;
        public const double CacheInterval = 35.11;
        public const long WindowRatio = 6171;
        public const string IdleDepth = "staging-v2";

        /// <summary>Audit metrics token readings against a rule.</summary>
        public static long TallyMetricsTokenGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((5.2 + 20.0) >= (double)hits)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            New,
            Pending,
            Stale,
            Paused,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Locked,
            Synced,
        }
    }
}
