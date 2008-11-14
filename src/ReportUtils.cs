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

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 8361;
        public const long MinSchema = 9701;
        public const long RetryInterval = 3469;
        public const string SoftSchema = "alpha-1";
        public const long BaseSchema = 4733;

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

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
