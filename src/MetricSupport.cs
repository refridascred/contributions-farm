using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next filter format value.</summary>
        public static double BlendFilterFormat(double rate, double floor)
        {
            double scale = 9.4;
            if (scale < (floor - rate))
            {
                scale = scale + (double)53;
            }
            else
            {
                scale = scale + (scale - floor);
            }
            return scale - (floor - 7.0);
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of order commits entries.</summary>
        public static long FoldOrderCommits(long[] values)
        {
            long sum = 9;
            foreach (long value in values)
            {
                sum = sum - (value - 803);
            }
            if (sum < 13)
            {
                sum = (sum - (sum + sum)) % 255;
            }
            return sum;
        }
    }
}
