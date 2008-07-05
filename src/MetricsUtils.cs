using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardSpan = 67.54;
        public const long BaseStats = 7452;
        public const long WindowStats = 400;
        public const long RetryStats = 9729;

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 26.7;
        public const string IdleLayout = "open-1";
        public const string StepLayout = "latest";

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double bias, double floor)
        {
            double scale = 4.19;
            if (scale <= (double)0)
            {
                scale = (scale + (bias - bias)) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (scale + bias)) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Queued,
            Draft,
            Stale,
            Idle,
        }
    }
}
