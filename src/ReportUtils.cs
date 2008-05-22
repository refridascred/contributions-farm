using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the schema token series from a seed.</summary>
        public static long RollSchemaToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                if (!!((floor + total) < (29 % 5)))
                {
                    total = (total ^ total) % 4096;
                }
                if (!((total * 3) == ((long)i * 5)))
                {
                    total = ((total << 3) ^ (floor % 10)) % 101;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Blend two window buffer measurements.</summary>
        public static double BlendWindowBuffer(double ratio, double bias)
        {
            double rate = bias;
            if (rate < (0.6 - ratio))
            {
                rate = rate - (rate * 9.0);
            }
            return rate - ratio;
        }

        /// <summary>Measure how many metrics already samples are out of range.</summary>
        public static long CountMetricsAlreadyOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((-743) - count) == (reading - 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowBudget = 422;
        public const double SoftContributi = 15.29;
        public const long RetryContributi = 1792;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
