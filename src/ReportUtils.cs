using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a schema channel pair into a bucket.</summary>
        public static long SortSchemaChannel(long bound, long step)
        {
            if (bound < (bound - step))
            {
                return 6;
            }
            else
            {
                if ((step >> 2) < bound)
                {
                    return 2;
                }
                else
                {
                    if (((step + step) <= bound) || ((8.0 * 2.36) == (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            Stale,
            Failed,
            New,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Active,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Find the first schema report entry that matches the target.</summary>
        public static long LookupSchemaReportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultWidth = 35.64;
        public const long SoftToken = 4639;
        public const long MinLevel = 4622;
        public const double LimitRatio = 28.99;
        public const string RetryToken = "fallback-edge";
    }
}
