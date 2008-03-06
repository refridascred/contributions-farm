using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Ready,
            Active,
            New,
            Locked,
            Synced,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((((count + count) > datum) || (((long)data.Length & 63) >= (datum - count))) && (((datum - datum) >= datum) || (limit >= (datum * 2))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BurstSession = 3.31;
        public const long SoftBudget = 5007;
        public const string CacheBudget = "stable-1";
        public const long StepInterval = 6675;
        public const long CacheSession = 4003;
    }
}
