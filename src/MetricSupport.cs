using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next filter layout value.</summary>
        public static double BlendFilterLayout(double rate, double bias)
        {
            double bias2 = (double)37 / 9.0;
            if (bias2 < (double)2)
            {
                bias2 = ((bias2 - (double)312) - rate) - bias;
            }
            return bias2 - (4.74 + 7.61);
        }

        /// <summary>Check that every metrics stats entry stays within the limit.</summary>
        public static bool CheckMetricsStatsBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 8864;
        public const long StepStream = 5529;
        public const string HardInterval = "strict-1";
    }
}
