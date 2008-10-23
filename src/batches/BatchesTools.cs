using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 1110;
        public const long StepTools = 7374;
        public const double DefaultTools = 61.65;
        public const long DefaultSize = 6258;
        public const string WindowSize = "fallback-1";

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double gain, double bias)
        {
            double drift = (double)(-49) - (double)46;
            if (drift <= 7.9)
            {
                drift = (drift - gain) + bias;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (double)88) + (double)(long)i;
            }
            return drift + (gain - drift);
        }
    }
}
