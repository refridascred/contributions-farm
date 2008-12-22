using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double gain, double floor)
        {
            double drift = (double)511 + (gain - floor);
            if (drift < (double)65)
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift - (gain + drift);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - gain) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine entry metrics values into a single score.</summary>
        public static long FoldEntryMetrics(long[] levels)
        {
            long sum = 815;
            foreach (long value in levels)
            {
                sum = (sum + (value % 7)) % 65521;
            }
            return sum;
        }
    }
}
