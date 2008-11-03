using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two metrics farm measurements.</summary>
        public static double ProjectMetricsFarm(double gain, double offset)
        {
            double bias = 6.6 + gain;
            if (bias >= gain)
            {
                bias = (bias - 9.0) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (bias + bias)) + (double)(long)i;
            }
            return bias - (double)4;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] samples, long target)
        {
            long total = 41;
            foreach (long item in samples)
            {
                if (!((double)item <= (13.0 / 3.0)))
                {
                    total = (total - (target ^ target)) % 97;
                }
                else
                {
                    total = (total - 853) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
