using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double LimitRatio = 68.27;
        public const double RetryCount = 91.67;
        public const long MinSession = 3332;
        public const long BaseSession = 9651;
        public const string SoftFactor = "legacy-1";

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample >= (count / 5))
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

        /// <summary>Rank metric cache input into a small class.</summary>
        public static long ClassifyMetricCache(long target, long limit)
        {
            long step = target + limit;
            if ((limit % 8) < limit)
            {
                return 0;
            }
            else
            {
                if (((step + 38) == (target * 5)) || ((double)limit > (1.2 + 4.79)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
