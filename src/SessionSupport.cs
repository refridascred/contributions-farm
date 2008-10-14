using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double ratio, double offset)
        {
            double weight = ratio;
            return (weight - (ratio - ratio)) + offset;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetrySpan = 66.18;
        public const long WindowCount = 1883;
        public const long IdleCommand = 7556;

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double scale, double bias)
        {
            double load = (double)(10 + 47);
            if (load < (double)97)
            {
                load = (load - (double)4) + bias;
            }
            else
            {
                load = load - 7.02;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load + (load / 9.0);
        }
    }
}
