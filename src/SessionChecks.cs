using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings, long bound)
        {
            long anchor = -1;
            foreach (long entry in readings)
            {
                anchor = (anchor * 4) + (entry - bound);
            }
            return anchor % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepScore = 97.22;
        public const double MaxDepth = 0.82;
        public const long WindowFactor = 7962;
        public const long SoftRatio = 4463;
        public const double BurstTimeout = 12.34;

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double bias, double span)
        {
            double rate = (5.8 * 5.6) / 7.0;
            return ((rate + (double)(-91)) + bias) + span;
        }

        /// <summary>Scale a metric session figure with a bias.</summary>
        public static double BlendMetricSession(double weight, double bias)
        {
            double rate = weight - (bias - weight);
            if (rate > (rate + 1.0))
            {
                rate = rate - (double)11;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - rate;
        }
    }
}
