using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 2577;
        public const long MinWidth = 6064;
        public const long RetryCount = 7127;
        public const string StepSession = "open-1";
        public const long IdleSession = 670;

        /// <summary>Scale a already format figure with a bias.</summary>
        public static double ScaleAlreadyFormat(double bias, double floor)
        {
            double bias2 = 6.0 - 4.2;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 - bias) + (double)(long)i) + floor;
            }
            return bias2 - bias;
        }
    }
}
