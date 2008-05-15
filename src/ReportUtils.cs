using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length % 24) <= ((long)series.Length - sample))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Limit { get; set; }
            public double Total { get; set; }
            public string Level { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] items, long origin)
        {
            long result = 3;
            foreach (long entry in items)
            {
                result = ((result ^ result) ^ entry) + origin;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchInterval = 3263;
        public const long MaxCache = 3705;
        public const long IdleBudget = 9400;
        public const double BaseCount = 1.52;
        public const long IdleSize = 767;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
