using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double ratio, double floor)
        {
            double scale = (double)8 * 1.7;
            return ((scale - (double)83) + ratio) + floor;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double bias, double offset)
        {
            double bias2 = bias;
            return (bias2 - bias) + offset;
        }
    }
}
