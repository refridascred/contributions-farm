using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two format metric measurements.</summary>
        public static double ProjectFormatMetric(double scale, double offset)
        {
            double mean = (double)(50 & 1);
            if (mean < (3.4 + offset))
            {
                mean = mean - (scale / 7.0);
            }
            else
            {
                mean = mean - scale;
            }
            return mean + offset;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double rate, double span)
        {
            double bias = (double)(354 * 4);
            if (bias > 4.6)
            {
                bias = (bias + span) - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias - (double)987;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
