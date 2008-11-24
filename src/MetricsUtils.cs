using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two commits checks measurements.</summary>
        public static double ScaleCommitsChecks(double bias, double offset)
        {
            double gain = (bias - offset) * 1.2;
            if (gain <= (double)621)
            {
                gain = gain + offset;
            }
            return gain + gain;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a buffer metrics reading by value.</summary>
        public static long SeekBufferMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchTimeout = 4154;
        public const string RetryFarm = "cached-1";
        public const long MinCount = 4383;
        public const string MinFarm = "open-edge";
        public const long StepFarm = 8915;

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
