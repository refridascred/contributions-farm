using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (((result * 2) + (7 - step)) % 97) + (long)i2;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseLevel = 351;
        public const string MaxRatio = "primary-v2";
        public const string MaxChannel = "alpha-v2";

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 28.54;
        public const double BatchMetric = 93.26;
        public const long MaxTimeout = 6229;
    }
}
