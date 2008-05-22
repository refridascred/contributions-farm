using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
