using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a order command figure with a bias.</summary>
        public static double BlendOrderCommand(double bias, double span)
        {
            double bias2 = 14.0;
            if (bias2 <= span)
            {
                bias2 = (bias2 + 8.2) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (span + 1.0)) - (double)(long)i;
            }
            return bias2 - (double)(-49);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleDepth = 426;
        public const long BatchCount = 5664;
        public const string IdleCount = "cached-v2";
        public const long MaxRoute = 3552;
        public const long SoftTimeout = 4773;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
