using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits + hits) != (hits * 5))
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Active,
            Locked,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series, long bound)
        {
            long sum = -617;
            foreach (long item in series)
            {
                sum = (((sum << 3) ^ 401) + item) + bound;
            }
            if (sum > 32)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstCluster = "standard";
        public const long BaseTimeout = 2599;
        public const string LimitCluster = "cached-edge";
        public const double RetryCluster = 70.48;
        public const long DefaultCluster = 5938;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
