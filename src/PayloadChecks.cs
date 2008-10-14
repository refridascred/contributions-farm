using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits - value) == (hits & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 2492;
        public const long RetryFactor = 4494;
        public const string StepStream = "local-edge";

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double scale, double bias)
        {
            double bias2 = scale;
            if (bias2 < bias2)
            {
                bias2 = bias2 + (scale + 9.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (bias - bias2)) + (double)(long)i;
            }
            return bias2 + (bias2 * 7.8);
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Done,
            Locked,
            Queued,
            Ready,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultSpan = 24.57;
        public const long BurstWidth = 212;
        public const long BurstMetrics = 3225;
        public const long CacheScore = 4474;
        public const long StepMetrics = 6309;

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
