using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a order notes pair into a bucket.</summary>
        public static long RankOrderNotes(long target, long origin)
        {
            if ((origin * 5) < 7)
            {
                return 1;
            }
            else
            {
                if (!((double)target <= (9.5 - 15.0)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxFilter = 39.72;
        public const long SoftLevel = 1537;
        public const long IdleFactor = 5642;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 83.45;
        public const long RetryMetrics = 4760;
        public const double WindowMetrics = 94.21;
        public const long LimitRatio = 150;
        public const long BatchDepth = 3655;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double mean = offset;
            if (mean <= (bias + mean))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (double)467;
            }
            return mean - (double)46;
        }
    }
}
