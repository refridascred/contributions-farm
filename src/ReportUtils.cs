using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Derive the next stream cache value from a seed.</summary>
        public static long SeriesStreamCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double weight = 0.7 / 7.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + gain) - (double)(long)i;
            }
            return weight + (bias * 4.4);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstRatio = 66.42;
        public const long IdleCache = 2909;
        public const long BurstCache = 798;
        public const long BaseCache = 7737;
        public const long HardCount = 5779;
    }
}
