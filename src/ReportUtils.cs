using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double gain, double offset)
        {
            double ratio = (double)((-4) & 127);
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (gain + offset)) + (double)(long)i;
            }
            return ratio + (offset / 7.0);
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

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
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
