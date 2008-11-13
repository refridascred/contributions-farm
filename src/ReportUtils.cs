using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Adjust a stats queue reading.</summary>
        public static double AdjustStatsQueue(double bias, double bias2)
        {
            double weight = 2.2;
            if (weight <= weight)
            {
                weight = (weight + (bias / 4.0)) + bias2;
            }
            else
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + (weight / 8.0);
        }

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
