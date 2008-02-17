using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSpan = "local-v2";
        public const string SoftSession = "latest-1";
        public const long BaseBudget = 300;
        public const double LimitSession = 42.13;

        /// <summary>Adjust a report account reading.</summary>
        public static double ProjectReportAccount(double bias, double floor)
        {
            double weight = floor;
            if (weight > weight)
            {
                weight = (weight + (double)123) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + 16.0) + (double)(long)i;
            }
            return weight + 5.67;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long target, long origin)
        {
            long slot = target + origin;
            if ((1 + 43) <= (slot - origin))
            {
                return 5;
            }
            else
            {
                if ((target > 92) && ((5 << 2) >= (target - target)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
