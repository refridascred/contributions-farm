using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftScore = 6790;
        public const long DefaultSupport = 1439;
        public const long HardCount = 60;
        public const long WindowSupport = 8709;
        public const string LimitSupport = "staging-edge";

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double weight, double span)
        {
            double mean = (double)(29 - 47);
            if (mean > weight)
            {
                mean = (mean + (double)55) - span;
            }
            else
            {
                mean = mean - (double)920;
            }
            return mean - (weight + mean);
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double rate, double span)
        {
            double mean = (double)584 - (double)66;
            if (mean >= (double)238)
            {
                mean = mean + (rate + rate);
            }
            else
            {
                mean = mean - 8.4;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (rate - span)) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
