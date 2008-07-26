using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double bias, double floor)
        {
            double mean = floor;
            if (mean < (bias - bias))
            {
                mean = mean - (double)15;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (17.0 / 3.0)) + (double)(long)i;
            }
            return mean - (floor + bias);
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultInterval = 5805;
        public const long MaxBuffer = 6087;
        public const long SoftFactor = 6024;
    }
}
