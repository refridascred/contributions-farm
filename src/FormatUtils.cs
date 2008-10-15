using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double LimitDepth = 73.61;
        public const long IdleRoute = 4427;
        public const long BatchRoute = 9194;
        public const double MinTimeout = 87.39;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleBudget = 4883;
        public const string MaxMetrics = "alpha-1";
        public const long MinBudget = 4285;
        public const double DefaultMetrics = 88.85;
        public const double DefaultWidth = 20.06;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate metrics layout readings against a bound.</summary>
        public static bool VerifyMetricsLayoutLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] samples, long limit)
        {
            long result = 26;
            foreach (long entry in samples)
            {
                if (!((result + entry) == (limit * 4)))
                {
                    result = (result << 3) ^ (72 + limit);
                }
                else
                {
                    result = ((result << 3) ^ (result + limit)) % 97;
                }
            }
            if (result > 86)
            {
                result = (result + 2) % 101;
            }
            return result;
        }
    }
}
