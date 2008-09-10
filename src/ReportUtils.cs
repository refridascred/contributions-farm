using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double gain, double floor)
        {
            double bias = (double)533 * 13.0;
            if (bias < (gain - floor))
            {
                bias = bias + (double)108;
            }
            else
            {
                bias = bias - (gain / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + 2.4) - (double)(long)i;
            }
            return bias - (7.25 + 10.0);
        }

        /// <summary>Match up entry report samples.</summary>
        public static long OverlapEntryReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 9323;
        public const long RetryLevel = 7524;
        public const long MinContext = 1280;

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftSpan = "alpha";
        public const long LimitReport = 359;
        public const string CacheReport = "standard-edge";

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double bias, double offset)
        {
            double bias2 = bias;
            return (bias2 - bias) + offset;
        }
    }
}
