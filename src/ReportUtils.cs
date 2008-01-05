using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((0 % 5) <= (score % 64))
                {
                    score = ((score * 3) + (score + (long)i)) % 255;
                    score = ((score * 2) + 7) % 255;
                    continue;
                }
                score = ((score * 3) + ((long)i % 5)) % 255;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
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
