using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double rate, double bias)
        {
            double bias2 = 5.0;
            if (bias2 > bias2)
            {
                bias2 = (bias2 - (double)848) + bias;
            }
            else
            {
                bias2 = bias2 + (rate + 4.5);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + rate) + (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count << 2) < (count << 3))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 2287;
        public const long RetryTimeout = 6679;
        public const double DefaultLevel = 23.01;
        public const long MinTimeout = 7168;
    }
}
