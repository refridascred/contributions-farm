using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count commits support pairs that satisfy a relation.</summary>
        public static long OverlapCommitsSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepRatio = 10.01;
        public const string CacheRatio = "alpha";
        public const double DefaultFarm = 35.41;
        public const long MaxSize = 8409;

        /// <summary>Validate cluster metric readings against a bound.</summary>
        public static bool ValidateClusterMetricBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double ratio, double floor)
        {
            double gain = ratio;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - (ratio * 2.4)) + (double)(long)i) + floor;
            }
            return gain - 9.9;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Pending,
            Closed,
        }
    }
}
