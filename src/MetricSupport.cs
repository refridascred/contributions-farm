using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double scale, double bias)
        {
            double weight = scale;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + (double)725;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 2083;
        public const double RetryTools = 61.33;
        public const string MaxTools = "stable-v2";
        public const double SoftScore = 2.9;
        public const double DefaultCount = 64.09;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
